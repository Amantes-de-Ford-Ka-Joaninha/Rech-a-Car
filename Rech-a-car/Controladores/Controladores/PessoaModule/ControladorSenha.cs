using Controladores.Shared;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using System;
using System.Collections.Generic;
using System.Data;
using System.Security.Cryptography;
using System.Text;

namespace Controladores.PessoaModule
{
    public class ControladorSenha
    {
        private const string sqlInsereSenha =
            @"INSERT";

        private const string sqlRecuperarSenha =
            @"SELECT 
                *
            FROM 
                [TBSENHA]
            WHERE 
                [USER] = @USER";

        public Senha GetDadosSenha(string user)
        {
            return Db.Get(sqlRecuperarSenha, ConverterEmSenha, new Dictionary<string, object>() { { "USER", user } });
        }
        public bool SenhaCorreta(string user, string senha)
        {
            var dadosSenha = GetDadosSenha(user);
            var hash = GerarHash(senha, dadosSenha.Salt);

            return hash == dadosSenha.Hash;
        }
        public void InserirSenha(int id_funcionario, string senha)
        {
            var salt = GerarSalt();
            var hash = GerarHash(senha, salt);
            Db.Insert(sqlInsereSenha, new Dictionary<string, object>() { { "HASH_SENHA", hash }, { "SALT", salt }, { "ID_FUNCIONARIO", id_funcionario } });
        }
        private byte[] GerarSalt()
        {
            byte[] salt = new byte[128 / 8];
            using (var rngCsp = new RNGCryptoServiceProvider())
            {
                rngCsp.GetNonZeroBytes(salt);
            }

            return salt;
        }

        private string GerarHash(string senha, byte[] salt)
        {
            return Convert.ToBase64String(KeyDerivation.Pbkdf2(
                                        password: senha,
                                        salt: salt,
                                        prf: KeyDerivationPrf.HMACSHA256,
                                        iterationCount: 100000,
                                        numBytesRequested: 256 / 8));
        }

        public Senha ConverterEmSenha(IDataReader reader)
        {
            var salt = (byte[])reader["SALT"];
            var hash = Convert.ToBase64String((byte[])reader["HASH_SENHA"]);

            return new Senha(salt, hash);
        }

        public class Senha
        {
            public Senha(byte[] salt, string hash)
            {
                Salt = salt;
                Hash = hash;
            }
            public byte[] Salt { get; }
            public string Hash { get; }
        }
    }
}
