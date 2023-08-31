using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

using EMAKE_API.src.interfaces;
using System.Drawing;
using Microsoft.VisualBasic;
using System.Reflection;

using EMAKE_API.src.modules;
namespace EMAKE_API.src.client
{
    public class Client
    {
        private List<interfaces.Module> modules;

        public Client()
        {
            this.modules = new List<interfaces.Module>();

            this.Start();
        }

        public void Start()
        {

            this.Log("CLIENT INICIADO!", "yellow", "Client");

            this.loadModules();
        }

        public void loadModules()
        {
            modules.SUAP SUAP = new modules.SUAP(this);

            this.modules.Add(SUAP.Start());

            Type type = typeof(modules.SUAP);

            this.modules.ForEach(modules =>
            {
                Type type = modules.GetType();

                this.Log("Carregando o módulo " + type.Name, "yellow", "Client");

                this.Log("Módulo " + type.Name + " carregado com sucesso!", "green", "Client");
            });
        }
        public void Log(string message, string color, string tag)
        {

            Console.ForegroundColor = this.getColor("Blue");

            Console.Write("[" + tag + "] ");

            Console.ForegroundColor = this.getColor(color);

            Console.Write(message + "\n");

            Console.ResetColor();
        }

        public ConsoleColor getColor(string color)
        {
            switch (color.ToLower())
            {
                case "blue":
                    return ConsoleColor.Blue;

                case "green":
                    return ConsoleColor.Green;

                case "red":
                    return ConsoleColor.Red;

                case "yellow":

                    return ConsoleColor.Yellow;

                case "white":
                    return ConsoleColor.White;

                default:
                    return ConsoleColor.White;
            }
        }
    }
}

