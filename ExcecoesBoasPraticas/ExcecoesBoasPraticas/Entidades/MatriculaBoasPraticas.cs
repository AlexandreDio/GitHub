using ExcecoesBoasPraticas.Entidades.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcecoesBoasPraticas.Entidades
{
    class MatriculaBoasPraticas
    {
        private int numLab;
        private DateTime dataInicio;
        private DateTime dataFim;

        public int NumLab { get => numLab; set => numLab = value; }
        public DateTime DataInicio { get => dataInicio; set => dataInicio = value; }
        public DateTime DataFim { get => dataFim; set => dataFim = value; }

        public MatriculaBoasPraticas()
        {
        }

        public MatriculaBoasPraticas(int numLab, DateTime dataInicio, DateTime dataFim)
        {
            if (dataFim <= DataInicio)
            {
                throw new DataInicioMatriculaException("Data de encerramento precisa ser depois da data de início!");
            }

            NumLab = numLab;
            DataInicio = dataInicio;
            DataFim = dataFim;
        }

        public int DuracaoCurso()
        {
            TimeSpan dias = DataFim.Subtract(DataInicio);
            return (int) dias.TotalDays;
        }

        public void AtualizaDataCurso(DateTime datainicio, DateTime datafim)
        {
            DateTime agora = DateTime.Now;
            if (datainicio < agora || datafim < agora)
            {
                throw new DataInicioMatriculaException("Data de início para atualização precisa ser uma data futura!");
            }

            if (datafim <= datainicio)
            {
                throw new DataInicioMatriculaException("Data de encerramento precisa ser depois da data de início!");
            }

            DataInicio = datainicio;
            DataFim = datafim;
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
