using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excecoes.Entidades
{
    class MatriculaMuitoRuim
    {
        private int numeroLab;
        private DateTime dataInicio;
        private DateTime dataFim;

        public int NumeroLab { get => numeroLab; set => numeroLab = value; }
        public DateTime DataInicio { get => dataInicio; set => dataInicio = value; }
        public DateTime DataFim { get => dataFim; set => dataFim = value; }

        public MatriculaMuitoRuim()
        {

        }

        public MatriculaMuitoRuim(int numeroLab, DateTime dataInicio, DateTime dataFim)
        {
            this.numeroLab = numeroLab;
            this.dataInicio = dataInicio;
            this.dataFim = dataFim;
        }

        public int DuracaoCurso()
        {
            TimeSpan duracao = DataFim.Subtract(DataInicio);
            return (int)duracao.TotalDays;
        }

        public void AtualizaDataCurso(DateTime datainicio, DateTime datafim)
        {
            DataInicio = datainicio;
            DataFim = datafim;
        }

        public override string ToString()
        {
            return "Número do laboratório: "
                + NumeroLab
                + ", Data de início (dd/MM/yyyy): "
                + DataInicio.ToString("dd/MM/yyyy")
                + ", Data de encerramento (dd/MM/yyyy): "
                + DataFim.ToString("dd/MM/yyyy")
                + " , "
                + DuracaoCurso()
                + " dias.";
        }
    }
}
