using BookManagementSystem.Data.Helpers;
using BookManagementSystem.Entities;
using System.Collections.Generic;
using System.Configuration;

namespace BookManagementSystem.Data
{
    public class ProcesamientoOcrTransferDAO
    {
        public static List<ProcesamientoOcrTransfer> SelectTs(short scltcod, int idOperatoria)
        {
            var resultado = new List<ProcesamientoOcrTransfer>();

            using (var conexion = FactoryDataBase.Create())
            using (var comando = conexion.CreateCommand())
            {
                comando.CommandText = string.Format(@"SELECT
                                                            POT.PT_ID ,
                                                            POT.PT_RUTA ,
                                                            POT.PT_NOMBRE_ARCHIVO ,
                                                            POT.PT_BUCKET ,
                                                            POT.PT_SCLTCOD ,
                                                            POT.PT_IDOPERATORIA ,
                                                            POT.PT_NUNICODOC ,
                                                            POT.PT_NUNICODOCT ,
                                                            POT.PT_DOCCOD ,
                                                            POT.PT_NROIDENTDOC ,
                                                            POT.PT_NROREFERENC ,
                                                            POT.PT_IDIMAGEN ,
                                                            POT.PT_ESTATUS ,
                                                            POT.PT_FECHA ,
                                                            POT.PT_IDPILA  ,
                                                            CC.CATEGORIA
                                                        FROM
                                                            {1}PROCESAMIENTO_OCR_TRANSFER POT
                                                            INNER JOIN {0}CHECKLIST_CAP CC ON POT.PT_NUNICODOC=CC.NUNICODOC 
                                                                                          AND POT.PT_NUNICODOCT=CC.NUNICODOCT
                                                       WHERE 
                                                            POT.PT_SCLTCOD=:SCLTCOD
                                                            AND POT.PT_IDOPERATORIA=:IDOPERATORIA
                                                            AND POT.PT_NUNICODOC IN (SELECT 
                                                                                           DISTINCT A.NUNICODOC 
                                                                                       FROM 
                                                                                           (SELECT 
                                                                                                  DISTINCT POT.PT_NUNICODOC NUNICODOC
                                                                                              FROM
                                                                                                  {1}PROCESAMIENTO_OCR_TRANSFER POT
                                                                                                  LEFT JOIN {1}PROCESAMIENTO_TRANSFORM PT ON PT.SCLTCOD=POT.PT_SCLTCOD
                                                                                                                                         AND PT.IDOPERATORIA=POT.PT_IDOPERATORIA
                                                                                                                                         AND PT.NUNICODOC=POT.PT_NUNICODOC
                                                                                                                                         AND PT.DOCCOD=POT.PT_DOCCOD 
                                                                                             WHERE 
                                                                                                  PT.SCLTCOD IS NULL 
                                                                                                  AND PT.IDOPERATORIA IS NULL 
                                                                                                  AND PT.DOCCOD IS NULL 
                                                                                                  AND PT.NUNICODOC IS NULL 
                                                                                                  AND POT.PT_SCLTCOD=:SCLTCOD 
                                                                                                  AND POT.PT_IDOPERATORIA=:IDOPERATORIA) A
                                                                                        INNER JOIN (SELECT A.NUNICODOC FROM (
                                                                                                           SELECT C.NUNICODOC, C.NROIDENTDOC, C.DOCCOD, (SUM(P.SIZE_BYTES) / 1024) / 1024 AS TAMANIO, FI.IDOPERATORIA AS OPERATORIA
                                                                                                           FROM {0}PAGINA_DIG P 
                                                                                                           INNER JOIN {0}CABECERA_DOC C ON P.NUNICODOC = C.NUNICODOC
                                                                                                           INNER JOIN {0}FLOW_INGRESOS_DETA_MP FD   ON C.NUNICODOC=FD.NUNICODOC
                                                                                                           INNER JOIN {0}FLOW_INGRESOS_CAB_MP FI ON FD.IDRECIBO=FI.IDRECIBO
                                                                                                       WHERE C.SCLTCOD=:SCLTCOD
                                                                                                       GROUP BY
                                                                                                           C.NUNICODOC,
                                                                                                           C.DOCCOD,
                                                                                                           C.NROIDENTDOC, 
                                                                                                               FI.IDOPERATORIA
                                                                                                       ) A WHERE A.TAMANIO>=50) B ON A.NUNICODOC=B.NUNICODOC
                                                                                   WHERE
                                                                                        ROWNUM=1 AND A.NUNICODOC>0)
                                                    ORDER BY
                                                            CC.CATEGORIA", ConfigurationManager.AppSettings["PROD"], ConfigurationManager.AppSettings["METEPEC"]);

                conexion.AddParameter(comando, "SCLTCOD", scltcod);
                conexion.AddParameter(comando, "IDOPERATORIA", idOperatoria);

                using (var lector = comando.ExecuteReader())
                    while (lector.Read())
                        resultado.Add(MappingDAOs.MapToClass<ProcesamientoOcrTransfer>(lector));
            }

            return resultado;
        }

        public static ProcesamientoOcrTransfer SelectU(short scltcod, int idOperatoria)
        {
            var resultado = (ProcesamientoOcrTransfer)null;

            using (var conexion = FactoryDataBase.Create())
            using (var comando = conexion.CreateCommand())
            {
                comando.CommandText = string.Format(@"SELECT
                                                            PT_ID ,
                                                            PT_RUTA ,
                                                            PT_NOMBRE_ARCHIVO ,
                                                            PT_BUCKET ,
                                                            PT_SCLTCOD ,
                                                            PT_IDOPERATORIA ,
                                                            PT_NUNICODOC ,
                                                            PT_NUNICODOCT ,
                                                            PT_DOCCOD ,
                                                            PT_NROIDENTDOC ,
                                                            PT_NROREFERENC ,
                                                            PT_IDIMAGEN ,
                                                            PT_ESTATUS ,
                                                            PT_FECHA ,
                                                            PT_IDPILA  
                                                        FROM
                                                            {1}PROCESAMIENTO_OCR_TRANSFER
                                                       WHERE 
                                                            PT_SCLTCOD=:SCLTCOD
                                                            AND PT_IDOPERATORIA=:IDOPERATORIA
                                                            AND PT_NUNICODOC IN (SELECT 
                                                                                        DISTINCT A.NUNICODOC 
                                                                                    FROM 
                                                                                        (SELECT 
                                                                                               DISTINCT POT.PT_NUNICODOC NUNICODOC
                                                                                           FROM
                                                                                               {1}PROCESAMIENTO_OCR_TRANSFER POT
                                                                                               LEFT JOIN {1}PROCESAMIENTO_TRANSFORM PT ON PT.SCLTCOD=POT.PT_SCLTCOD
                                                                                                                                      AND PT.IDOPERATORIA=POT.PT_IDOPERATORIA
                                                                                                                                      AND PT.NUNICODOC=POT.PT_NUNICODOC
                                                                                                                                      AND PT.DOCCOD=POT.PT_DOCCOD 
                                                                                          WHERE 
                                                                                               PT.SCLTCOD IS NULL 
                                                                                               AND PT.IDOPERATORIA IS NULL 
                                                                                               AND PT.DOCCOD IS NULL 
                                                                                               AND PT.NUNICODOC IS NULL 
                                                                                               AND POT.PT_SCLTCOD=:SCLTCOD 
                                                                                               AND POT.PT_IDOPERATORIA=:IDOPERATORIA) A
                                                                                        INNER JOIN (SELECT A.NUNICODOC FROM (
                                                                                                           SELECT C.NUNICODOC, C.NROIDENTDOC, C.DOCCOD, (SUM(P.SIZE_BYTES) / 1024) / 1024 AS TAMANIO, FI.IDOPERATORIA AS OPERATORIA
                                                                                                           FROM {0}PAGINA_DIG P 
                                                                                                           INNER JOIN {0}CABECERA_DOC C ON P.NUNICODOC = C.NUNICODOC
                                                                                                           INNER JOIN {0}FLOW_INGRESOS_DETA_MP FD   ON C.NUNICODOC=FD.NUNICODOC
                                                                                                           INNER JOIN {0}FLOW_INGRESOS_CAB_MP FI ON FD.IDRECIBO=FI.IDRECIBO
                                                                                                       WHERE C.SCLTCOD=:SCLTCOD
                                                                                                       GROUP BY
                                                                                                           C.NUNICODOC,
                                                                                                           C.DOCCOD,
                                                                                                           C.NROIDENTDOC, 
                                                                                                               FI.IDOPERATORIA
                                                                                                       ) A WHERE A.TAMANIO>=50) B ON A.NUNICODOC=B.NUNICODOC
                                                                                   WHERE
                                                                                        ROWNUM=1 AND A.NUNICODOC>0)", ConfigurationManager.AppSettings["PROD"], ConfigurationManager.AppSettings["METEPEC"]);

                conexion.AddParameter(comando, "SCLTCOD", scltcod);
                conexion.AddParameter(comando, "IDOPERATORIA", idOperatoria);

                using (var lector = comando.ExecuteReader())
                    if (lector.Read())
                        resultado = MappingDAOs.MapToClass<ProcesamientoOcrTransfer>(lector);
            }

            return resultado;
        }
    }
}