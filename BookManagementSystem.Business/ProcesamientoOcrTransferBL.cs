using BookManagementSystem.Data;
using BookManagementSystem.Entities;
using System.Collections.Generic;

namespace BookManagementSystem.Business
{
    public class ProcesamientoOcrTransferBL
    {
        public static List<ProcesamientoOcrTransfer> ObtenerTs(short scltcod, int idOperatoria)
        {
            return ProcesamientoOcrTransferDAO.SelectTs(scltcod, idOperatoria);
        }

        public static ProcesamientoOcrTransfer ObtenerU(short scltcod, int idOperatoria)
        {
            return ProcesamientoOcrTransferDAO.SelectU(scltcod, idOperatoria);
        }
    }
}