using DevExpress.XtraBars.Docking2010.Customization;
using Ebda3Soft.Core.Database.Interfaces;
using Ebda3Soft.Core.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ebda3Soft.Core.Database.Entities.GeneralSettings
{
    public class User : BaseEntity
    {
        [Display(Order = -1)]
        public Guid UserID { get; set; } = Guid.NewGuid();
        [Required, StringLength(300), Index(IsUnique = true)]
        public String FullName { get; set; }
        [Required, StringLength(300), Index(IsUnique = true)]
        public string LoginID { get; set; }
        [Display(Order = -1), Required(ErrorMessage = "You have to enter the password")]
        public string HashedPassword { get; set; }

        private string oldHash;
        private string plainText;
        private string passwordConfirmation;

        [NotMapped]
        public string PlainText
        {
            get
            {
                return plainText;
            }
            set
            {
                plainText = value;
                if (value != string.Empty && plainText == passwordConfirmation)
                {
                    HashedPassword = HashFunction(value);
                }
            }
        }
        [NotMapped]
        public string PasswordConfirmation
        {
            get => passwordConfirmation; set
            {
                passwordConfirmation = value;
                if (value != string.Empty && plainText == passwordConfirmation)
                {
                    HashedPassword = HashFunction(value);
                }
            }
        }

        public bool IsSuperAdmin { get; set; }
        public bool IsAdmin { get; set; }

        public bool IsEnabled { get; set; }

        [Display(Order = -1)]
        public virtual ICollection<UserViewInfo> UserViews { get; set; }

        public override string DisplayMember => FullName;

        public override Guid KeyMember => UserID;

        internal static string HashFunction(string s)
        {
            var crypt = new SHA256Managed();
            string hash = String.Empty;
            byte[] crypto = crypt.ComputeHash(Encoding.ASCII.GetBytes(s));
            foreach (byte theByte in crypto)
            {
                hash += theByte.ToString("x2");
            }
            return hash;
        }
        public override bool IsReadyToSave()
        {
            if (!base.IsReadyToSave())
                return false;

            

            if (PasswordConfirmation != PlainText)
            {
                FlyoutDialog.Show(this.ParentForm, "Error", "The password and its confirmation doesnt match", MessageBoxButtons.OK);
                return false;
            }

            return true;
        }
    }
}
