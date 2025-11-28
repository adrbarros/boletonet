using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BoletoNet
{
    #region Enumerado

    public enum EnumEspecieDocumento_Cresol
    {
        DuplicataMercantil,
        NotaPromissoria,
        NotaSeguro,
        CobrancaSeriada,
        Recibo,
        LetraCambio,
        NotaDebito,
        DuplicataServico,
        Outros,
    }

    #endregion
    public class EspecieDocumento_Cresol : AbstractEspecieDocumento, IEspecieDocumento
    {
        #region Construtores

        public EspecieDocumento_Cresol()
        {
            try
            {
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao carregar objeto", ex);
            }
        }

        public EspecieDocumento_Cresol(string codigo)
        {
            try
            {
                this.carregar(codigo);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao carregar objeto", ex);
            }
        }

        #endregion

        #region Metodos Privados
        public string getCodigoEspecieByEnum(EnumEspecieDocumento_Cresol especie)
        {
            switch (especie)
            {
                case EnumEspecieDocumento_Cresol.DuplicataMercantil: return "1";
                case EnumEspecieDocumento_Cresol.NotaPromissoria: return "2";
                case EnumEspecieDocumento_Cresol.NotaSeguro: return "3";
                case EnumEspecieDocumento_Cresol.CobrancaSeriada: return "4";
                case EnumEspecieDocumento_Cresol.Recibo: return "5";
                case EnumEspecieDocumento_Cresol.LetraCambio: return "10";
                case EnumEspecieDocumento_Cresol.NotaDebito: return "11";
                case EnumEspecieDocumento_Cresol.DuplicataServico: return "12";
                case EnumEspecieDocumento_Cresol.Outros: return "99";
                default: return "99";

            }
        }

        public EnumEspecieDocumento_Cresol getEnumEspecieByCodigo(string codigo)
        {
            switch (codigo)
            {
                case "1": return EnumEspecieDocumento_Cresol.DuplicataMercantil;
                case "2": return EnumEspecieDocumento_Cresol.NotaPromissoria;
                case "3": return EnumEspecieDocumento_Cresol.NotaSeguro;
                case "4": return EnumEspecieDocumento_Cresol.CobrancaSeriada;
                case "5": return EnumEspecieDocumento_Cresol.Recibo;
                case "10": return EnumEspecieDocumento_Cresol.LetraCambio;
                case "11": return EnumEspecieDocumento_Cresol.NotaDebito;
                case "12": return EnumEspecieDocumento_Cresol.DuplicataServico;
                case "99": return EnumEspecieDocumento_Cresol.Outros;
                default: return EnumEspecieDocumento_Cresol.Outros;
            }
        }

        public override string getCodigoEspecieBySigla(string sigla)
        {
            switch (sigla)
            {
                case "DM": return "1";
                case "NP": return "2";
                case "NS": return "3";
                case "CS": return "4";
                case "RC": return "5";
                case "LC": return "10";
                case "ND": return "11";
                case "DS": return "12";
                default: return "99";
            }
        }

        private void carregar(string idCodigo)
        {
            try
            {
                this.Banco = new Banco_Cresol();

                switch (getEnumEspecieByCodigo(idCodigo))
                {
                    case EnumEspecieDocumento_Cresol.DuplicataMercantil:
                        this.Codigo = getCodigoEspecieByEnum(EnumEspecieDocumento_Cresol.DuplicataMercantil);
                        this.Especie = "Duplicata mercantil";
                        this.Sigla = "DM";
                        break;
                    case EnumEspecieDocumento_Cresol.NotaPromissoria:
                        this.Codigo = getCodigoEspecieByEnum(EnumEspecieDocumento_Cresol.NotaPromissoria);
                        this.Especie = "Nota promissória";
                        this.Sigla = "NP";
                        break;
                    case EnumEspecieDocumento_Cresol.NotaSeguro:
                        this.Codigo = getCodigoEspecieByEnum(EnumEspecieDocumento_Cresol.NotaSeguro);
                        this.Especie = "Nota de seguro";
                        this.Sigla = "NS";
                        break;
                    case EnumEspecieDocumento_Cresol.CobrancaSeriada:
                        this.Codigo = getCodigoEspecieByEnum(EnumEspecieDocumento_Cresol.CobrancaSeriada);
                        this.Especie = "Cobrança seriada";
                        this.Sigla = "CS";
                        break;
                    case EnumEspecieDocumento_Cresol.Recibo:
                        this.Codigo = getCodigoEspecieByEnum(EnumEspecieDocumento_Cresol.Recibo);
                        this.Especie = "Recibo";
                        this.Sigla = "RC";
                        break;
                    case EnumEspecieDocumento_Cresol.LetraCambio:
                        this.Codigo = getCodigoEspecieByEnum(EnumEspecieDocumento_Cresol.LetraCambio);
                        this.Sigla = "LC";
                        this.Especie = "Letra de câmbio";
                        break;
                    case EnumEspecieDocumento_Cresol.NotaDebito:
                        this.Codigo = getCodigoEspecieByEnum(EnumEspecieDocumento_Cresol.NotaDebito);
                        this.Sigla = "ND";
                        this.Especie = "Nota de débito";
                        break;
                    case EnumEspecieDocumento_Cresol.DuplicataServico:
                        this.Codigo = getCodigoEspecieByEnum(EnumEspecieDocumento_Cresol.DuplicataServico);
                        this.Sigla = "DS";
                        this.Especie = "Duplicata de serviço";
                        break;
                    case EnumEspecieDocumento_Cresol.Outros:
                        this.Codigo = getCodigoEspecieByEnum(EnumEspecieDocumento_Cresol.Outros);
                        this.Especie = "Outros";
                        break;
                    default:
                        this.Codigo = "0";
                        this.Especie = "( Selecione )";
                        this.Sigla = "";
                        break;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao carregar objeto", ex);
            }
        }

        public static EspeciesDocumento CarregaTodas()
        {
            try
            {
                EspeciesDocumento alEspeciesDocumento = new EspeciesDocumento();

                EspecieDocumento_Cresol obj = new EspecieDocumento_Cresol();

                obj = new EspecieDocumento_Cresol(obj.getCodigoEspecieByEnum(EnumEspecieDocumento_Cresol.DuplicataMercantil));
                alEspeciesDocumento.Add(obj);

                obj = new EspecieDocumento_Cresol(obj.getCodigoEspecieByEnum(EnumEspecieDocumento_Cresol.NotaPromissoria));
                alEspeciesDocumento.Add(obj);

                obj = new EspecieDocumento_Cresol(obj.getCodigoEspecieByEnum(EnumEspecieDocumento_Cresol.NotaSeguro));
                alEspeciesDocumento.Add(obj);

                obj = new EspecieDocumento_Cresol(obj.getCodigoEspecieByEnum(EnumEspecieDocumento_Cresol.CobrancaSeriada));
                alEspeciesDocumento.Add(obj);

                obj = new EspecieDocumento_Cresol(obj.getCodigoEspecieByEnum(EnumEspecieDocumento_Cresol.Recibo));
                alEspeciesDocumento.Add(obj);

                obj = new EspecieDocumento_Cresol(obj.getCodigoEspecieByEnum(EnumEspecieDocumento_Cresol.LetraCambio));
                alEspeciesDocumento.Add(obj);

                obj = new EspecieDocumento_Cresol(obj.getCodigoEspecieByEnum(EnumEspecieDocumento_Cresol.NotaDebito));
                alEspeciesDocumento.Add(obj);

                obj = new EspecieDocumento_Cresol(obj.getCodigoEspecieByEnum(EnumEspecieDocumento_Cresol.DuplicataServico));
                alEspeciesDocumento.Add(obj);

                obj = new EspecieDocumento_Cresol(obj.getCodigoEspecieByEnum(EnumEspecieDocumento_Cresol.Outros));
                alEspeciesDocumento.Add(obj);

                return alEspeciesDocumento;

            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao listar objetos", ex);
            }
        }

        public override IEspecieDocumento DuplicataMercantil()
        {
            return new EspecieDocumento_Cresol(getCodigoEspecieByEnum(EnumEspecieDocumento_Cresol.DuplicataMercantil));
        }
        #endregion Meotods Privados
    }
}
