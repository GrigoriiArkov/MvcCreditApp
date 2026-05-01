using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MvcCreditApp.Models
{
    public class Credit
    {
        //ID кредита 
        public virtual int CreditId { get; set; }

        //Name
        [DisplayName("Название кредита")]
        [Required(ErrorMessage = "Название кредита обязательно")]
        public virtual string? Head { get; set; }

        //период на который выдается кредит
        [DisplayName("Период кредитования")]
        [Required(ErrorMessage = "Период кредитования обязателен")]
        public virtual int Period { get; set; }

        //Максимальная сумма кредита
        [DisplayName("Максимальная сумма")]
        [Required(ErrorMessage = "Сумма кредита обязательна")]
        public virtual int? Sum { get; set; }

        //Процентная ставка
        [DisplayName("Процентная ставка (%)")]
        [Required(ErrorMessage = "Процентная ставка обязательна")]
        public virtual int? Procent { get; set; }
    }
}
