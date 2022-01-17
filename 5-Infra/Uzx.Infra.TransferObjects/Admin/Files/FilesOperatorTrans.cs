using System;

namespace Uzx.Infra.TransferObjects.Admin
{
    public  class FilesOperatorTrans
    {
        public  Guid FileId { get; set; }
        public  Guid ClientId { get; set; }
        public  Guid OperatorId { get; set; }
        public  TpFileOperator TpFileOperator { get; set; }
        public  FileStatus Status { get; set; }
        public  bool IsTratado { get; set; }
        public  DateTime DTTratamento { get; set; }
    }

    public  enum FileStatus : int
    {
        NaoProcessado = 0,
        ComErro = 1,
        ProcessadoComSucesso = 2
    };

    public  enum TpFileOperator : int
    {
        Intermedica = 1,
        Unimed = 2,
        PortoSeguro = 3,
        Sulamerica = 4
    };
}