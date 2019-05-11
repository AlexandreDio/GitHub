using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcecoesRuim.Entidades
{
    class MatriculaRuim
    {
        private int numLab;
        private DateTime dataInicio;
        private DateTime dataFim;

        public int NumLab { get => numLab; set => numLab = value; }
        public DateTime DataInicio { get => dataInicio; set => dataInicio = value; }
        public DateTime DataFim { get => dataFim; set => dataFim = value; }

        public MatriculaRuim()
        {
        }

        public MatriculaRuim(int numLab, DateTime dataInicio, DateTime dataFim)
        {
            NumLab = numLab;
            DataInicio = dataInicio;
            DataFim = dataFim;
        }

        public int DuracaoCurso()
        {
            TimeSpan dias = DataFim.Subtract(DataInicio);
            return (int) dias.TotalDays;
        }

        public string AtualizaDataCurso(DateTime datainicio, DateTime datafim)
        {
            DateTime agora = DateTime.Now;
            if (datainicio < agora || datafim < agora)
            {
                return "Data para atualização precisa ser uma data futura";
            }

            if (datafim <= datainicio)
            {
                return "Data do encerramento do curso precisa ser superior a data de início";
            }

            DataInicio = datainicio;
            dataFim = datafim;

            return null;
        }

        public override string ToString()
        {
            return "Laboratório: "
                + NumLab
                + ", início: "
                + DataInicio.ToString("dd/MM/yyyy")
                + ", encerramento: "
                + DataFim.ToString("dd/MM/yyyy")
                + ", Duração: "
                + DuracaoCurso()
                + " dias.";
        }
    }
}
