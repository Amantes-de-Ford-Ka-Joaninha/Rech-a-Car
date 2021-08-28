using Controladores.Shared;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Controladores.PessoaModule
{
    public class ControladorSenha
    {
        private const string sqlSenhaCorreta =
            @"SELECT 
                COUNT(*) 
            FROM 
                [TBSENHA]
            WHERE 
                [USER] = @USER
            AND
                [HASH] = @HASH";

        public bool Validar(int id_funcionario, string senha)
        {
            byte[] salt = new byte[128 / 8];
            using (var rngCsp = new RNGCryptoServiceProvider())
            {
                rngCsp.GetNonZeroBytes(salt);
            }

            string hash = Convert.ToBase64String(KeyDerivation.Pbkdf2(
                password: senha,
                salt: salt,
                prf: KeyDerivationPrf.HMACSHA256,
                iterationCount: 100000,
                numBytesRequested: 256 / 8));

            return SenhaCorreta(id_funcionario, hash);
        }

        private bool SenhaCorreta(int id_funcionario, string hash)
        {
            return Db.Exists(sqlSenhaCorreta, new Dictionary<string, object>() { { "HASH_SENHA", hash }, { "ID_FUNCIONARIO", id_funcionario } });
        }
    }
}
