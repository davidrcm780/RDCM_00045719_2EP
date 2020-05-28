using System;
using System.Collections.Generic;
using System.Data;

namespace Parcial02
{
    public class UsuarioDAO
    {
        public static void updatepassword(string usuario, string newPassword)
        {
            string sql = String.Format(
                "update appuser set password='{0}' where username='{1}';", newPassword, usuario);

            Connection.ExecuteQuery(sql);
        }
    }
}