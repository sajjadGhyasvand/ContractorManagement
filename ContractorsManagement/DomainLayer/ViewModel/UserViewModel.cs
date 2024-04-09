using DomainLayer.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.ViewModel
{
    public class UserViewModel
    {
        [Display(Name = "نام")]
        [Required(AllowEmptyStrings = false,ErrorMessage ="{0}  وارد نشده است")]
        [StringLength(maximumLength:100,MinimumLength =2,ErrorMessage ="{0} باید حداقل {1} و حداکثر {2} باشد")]
        [RegularExpression(@"^[^\\/:*;\.\)\(]+$",ErrorMessage ="از کارکترهای غیر مجاز استفاده نکنید.")]
        public string FirstName { get; set; }
        [Display(Name = "نام خانوادگی")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "{0}  وارد نشده است")]
        [StringLength(maximumLength: 250, MinimumLength = 2, ErrorMessage = "{0} باید حداقل {1} و حداکثر {2} باشد")]
        [RegularExpression(@"^[^\\/:*;\.\)\(]+$", ErrorMessage = "از کارکترهای غیر مجاز استفاده نکنید.")]
        public string LastName { get; set; }
        [Display(Name = "کد پرسنلی")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "{0}  وارد نشده است")]
        [MaxLength(10,ErrorMessage ="{0} باید {1} رقم باشد")]
        [MinLength(10,ErrorMessage ="{0} باید {1} رقم باشد")]
        public string PersonalCode { get; set; }
        [Display(Name = "کد ملی")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "{0}  وارد نشده است")]
        [MaxLength(10, ErrorMessage = "{0} باید {1} رقم باشد")]
        [MinLength(10, ErrorMessage = "{0} باید {1} رقم باشد")]
        [RegularExpression(@"^[0-9]*$", ErrorMessage = "از کارکترهای غیر مجاز استفاده نکنید.")]
        public string NationalCode { get; set; }
        [Display(Name = " آدرس")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "{0}  وارد نشده است")]
        public string? Address { get; set; }
        [Display(Name = "تاریخ تولد ")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "{0}  وارد نشده است")]
        public DateTime? BirthDate { get; set; }
        [Display(Name = "تاریخ استخدام ")]
        public DateTime? EmployeeDate { get; set; }
        [Display(Name = "حنسیت  ")]
        public Gender Gender { get; set; }
        [Display(Name = "تصویر  ")]
        public string ImagePath { get; set; }
        [Display(Name = " امضا ")]
        public string SignaturePath { get; set; }
        [Display(Name = "ایمیل ")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "{0}  وارد نشده است")]
        [EmailAddress(ErrorMessage ="فرمت{0} صحیح رعایت نشد")]
        public string Email { get; set; }
        [Display(Name = "شماره موبایل ")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "{0}  وارد نشده است")]
        [MaxLength(11, ErrorMessage = "{0} باید {1} رقم باشد")]
        [MinLength(11, ErrorMessage = "{0} باید {1} رقم باشد")]
        [RegularExpression(@"^[0-9]*$", ErrorMessage = "از کارکترهای غیر مجاز استفاده نکنید.")]
        public string PhoneNumber { get; set; }

        [Display(Name = "نام کاربری  ")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "{0}  وارد نشده است")]
        [StringLength(maximumLength: 40, MinimumLength = 4, ErrorMessage = "{0} باید حداقل 4 و حداکثر 40 باشد")]
        [RegularExpression(@"^[^\\/:*;\.\)\(]+$", ErrorMessage = "از کارکترهای غیر مجاز استفاده نکنید.")]
        public string UserName { get; set; }
    }
}
