using System;

namespace TeleHelp.Modelos
{
    public class ClsModelos
    {
        private string nomeFuncionario = string.Empty;
        private DateTime dtNascFuncionario = DateTime.MinValue;
        private int idadeFuncionario = byte.MinValue;
        private string cargoFuncionario = string.Empty;
        private int idFuncionario = int.MinValue;

        public string NomeFuncionario
        {
            get { return nomeFuncionario; }
            set { nomeFuncionario = value; }
        }

        public DateTime DataNascimento
        {
            get { return dtNascFuncionario; }
            set { dtNascFuncionario = value; }
        }

        public int IdadeFuncionario
        {
            get { return idadeFuncionario; }
            set { idadeFuncionario = value; }
        }

        public string CargoFuncionario
        {
            get { return cargoFuncionario; }
            set { cargoFuncionario = value; }
        }

        public int IdFuncionario
        {
            get { return idFuncionario; }
            set { idFuncionario = value; }
        }
    }
}
