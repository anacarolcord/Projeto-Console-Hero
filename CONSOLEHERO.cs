using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Cryptography.X509Certificates;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Threading;



namespace exercicios
{
    public class Program
    {


        static void Main(string[] args)
        {

            new InicioJogo().Inicio();

            new MissaoSoma().IniciarMissaoSoma();

            new MissaoMenu().IniciarMissaoMenu();

            new MissaoPedrasMagicas().IniciarMissaoPedrasMagicas();

            new MissaoPortal().IniciarMissaoPortal();

            new MenuMissao().IniciarMenuMissao();
        }
    }
}


       