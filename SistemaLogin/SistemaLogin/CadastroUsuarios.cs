using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaLogin
{
    static class CadastroUsuarios
    {
        private static Usuario[] usuarios =
        {
            new Usuario(){Nome = "Murilo", Senha = "abc123"},
            new Usuario(){Nome = "Diego", Senha = "cba321"},
            new Usuario(){Nome = "Elisete", Senha = "123abc"}
        };

        private static Usuario _userLogado = null;

        public static Usuario usuarioLogado 
        { 
            get { return _userLogado; } 
            private set { _userLogado = value; }
        }

        public static bool Login(string nome, string senha)
        {
            foreach (Usuario usuario in usuarios)
            {
                if(usuario.Nome == nome && usuario.Senha == senha)
                {
                    usuarioLogado = usuario;
                    return true;
                }
            }

            return false;
        }
    }
}
