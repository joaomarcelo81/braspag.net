using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BraspagAPI.Objects
{

    public class Payment
    {

        #region Boleto preperties

        /// <summary>
        /// Instruções Boleto
        /// </summary>
        public string Instructions { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string ExpirationDate { get; set; }
        /// <summary>
        /// Url do Boleto gerado
        /// </summary>
        public string Url { get; set; }
        /// <summary>
        /// NossoNumero gerado
        /// </summary>
        public string Number { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string BoletoNumber { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Demonstrative { get; set; }
        /// <summary>
        /// Representação numérica do código de barras
        /// </summary>
        public string BarCodeNumber { get; set; }
        /// <summary>
        /// Linha digitável
        /// </summary>
        public string DigitableLine { get; set; }
        public string Assignor { get; set; }
        public string Address { get; set; }
        public string Identification { get; set; }
        #endregion

        /// <summary>
        /// Tipo do Meio de Pagamento
        /// </summary>
        public string Type { get; set; }
        /// <summary>
        /// Valor do Pedido (ser enviado em centavos)
        /// </summary>
        public string Amount { get; set; }
        /// <summary>
        /// Moeda moeda na qual o pagamento será feito (BRL / USD / MXN / COP / CLP / ARS / PEN / EUR / PYN / UYU / VEB / VEF / GBP)
        /// </summary>
        public string Currency { get; set; }
        /// <summary>
        /// Pais na qual o pagamento será feito
        /// </summary>
        public string Country { get; set; }
        /// <summary>
        /// Nome do Meio de Pagamento
        /// </summary>
        public string Provider { get; set; }
        /// <summary>
        /// Montante do valor da autorização que deve ser destinado à taxa de serviço. Obs.: Esse valor não é adicionado ao valor da autorização
        /// </summary>
        public string ServiceTaxAmount { get; set; }
        /// <summary>
        /// Número de Parcelas
        /// </summary>
        public string Installments { get; set; }
        /// <summary>
        /// Tipo de parcelamento (Loja ou Cartão)
        /// </summary>
        public string Interest { get; set; }
        /// <summary>
        /// Booleano que identifica que a autorização deve ser com captura automática
        /// </summary>
        public string Capture { get; set; }
        /// <summary>
        /// Booleano que identifica que a autorização deve ser com autenticação
        /// </summary>
        public string Authenticate { get; set; }
        /// <summary>
        /// Texto que será impresso na fatura do portador
        /// </summary>
        public string SoftDescriptor { get; set; }
        /// <summary>
        /// URI para onde o usuário será redirecionado após o fim do pagamento
        /// </summary>
        public string ReturnUrl { get; set; }
        /// <summary>
        /// Número do Comprovante de Venda
        /// </summary>
        public string ProofOfSale { get; set; }
        /// <summary>
        /// Id da transação na adquirente. 
        /// </summary>
        public string AcquirerTransactionId { get; set; }
        /// <summary>
        /// Código de autorização
        /// </summary>
        public string AuthorizationCode { get; set; }
        /// <summary>
        /// Campo Identificador do Pedido
        /// </summary>
        public string PaymentId { get; set; }
        /// <summary>
        /// Eletronic Commerce Indicator. Representa o quão segura é uma transação
        /// </summary>
        public string ECI { get; set; }
        /// <summary>
        /// Total Capturado
        /// </summary>
        public string CapturedAmount { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string[] ExtraDataCollection { get; set; }
        /// <summary>
        /// Código da razão da Operação
        ///0	Successful
        ///1	AffiliationNotFound
        ///2	IssuficientFunds
        ///3	CouldNotGetCreditCard
        ///4	ConnectionWithAcquirerFailed
        ///5	InvalidTransactionType
        ///6	InvalidPaymentPlan
        ///7	Denied
        ///8	Scheduled
        ///9	Waiting
        ///10	Authenticated
        ///11	NotAuthenticated
        ///12	ProblemsWithCreditCard
        ///13	CardCanceled
        ///14	BlockedCreditCard
        ///15	CardExpired
        ///16	AbortedByFraud
        ///17	CouldNotAntifraud
        ///18	TryAgain
        ///19	InvalidAmount
        ///20	ProblemsWithIssuer
        ///21	InvalidCardNumber
        ///22	TimeOut
        ///98	InvalidRequest
        ///99	InternalError
        /// </summary>
        public string ReasonCode { get; set; }
        /// <summary>
        /// Mensagem da razação da Operação
        /// </summary>
        public string ReasonMessage { get; set; }
        /// <summary>
        /// Status da Transação
        /// </summary>
        public string Status { get; set; }
        /// <summary>
        /// Código de retorno da adquirente
        /// </summary>
        public string ProviderReturnCode { get; set; }
        /// <summary>
        /// Mensagem de retorno da adquirente
        /// </summary>
        public string ProviderReturnMessage { get; set; }
        /// <summary>
        /// Cartão de Credito 
        /// </summary>
        public CreditCard CreditCard { get; set; }
        /// <summary>
        /// Cartão de Debito
        /// </summary>
        public DebitCard DebitCard { get; set; }
        /// <summary>
        /// Links
        /// </summary>
        public IList<Link> Links { get; set; }
        /// <summary>
        /// Recurrent Payment
        /// </summary>
        public RecurrentPayment RecurrentPayment { get; set; }
    }
}
