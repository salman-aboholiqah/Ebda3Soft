using DevExpress.XtraBars.Docking2010.Customization;
using Ebda3Soft.Core.Database.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ebda3Soft.Core.Database.Entities.Financial
{
    public class Journal : BaseEntity
    {
        [Display(Order = -1)]
        public Guid JournalID { get; set; } = Guid.NewGuid();
        [Display(Order = -1)]
        public Guid JournalTypeID { get; set; }
        [ForeignKey("JournalTypeID")]
        public JournalType JournalType { get; set; }
        public long JournalNumber { get; set; }
        public DateTime JournalDate { get; set; } = DateTime.Now;
        [Display(Order = -1)]
        public Guid CreditAccountID { get; set; }
        [Display(Order = -1)]
        public Guid DebitAccountID { get; set; }

        [ForeignKey("CreditAccountID")]
        public Account CreditAccount { get; set; }
        [ForeignKey("DebitAccountID")]
        public Account DebitAccount { get; set; }
        public Decimal Credit { get; set; }
        public Decimal Debit { get; set; }
        public String Description { get; set; }
        [Display(Order = -1)]
        public Guid CurrencyID { get; set; }
        [ForeignKey("CurrencyID")]
        public Currency Currency { get; set; }

        public bool IsPosted { get; set; }

        [NotMapped]
        public Decimal JournalPrice
        {
            get => (Credit + Debit) / 2;
            set => Credit = Debit = value;
        }

        public override string DisplayMember => JournalType?.JournalTypeName + Description;

        public override Guid KeyMember => JournalID;
        public override string ToString()
        {
            return DisplayMember;
        }
        public override bool IsReadyToSave()
        {
            if (JournalTypeID == Guid.Empty)
            {
                FlyoutDialog.Show(this.ParentForm, "Error", "You have to chose the journal type", MessageBoxButtons.OK);
                return false;
            }
            if (SQLServerDbContext.Instance.Journals.Count(a => a.JournalTypeID == JournalID && a.JournalNumber == JournalNumber && a.JournalID != JournalID) > 0)
            {
                FlyoutDialog.Show(this.ParentForm, "Error", "The number is recorded before", MessageBoxButtons.OK);
                return false;
            }
            if (CreditAccountID == DebitAccountID)
            {
                FlyoutDialog.Show(this.ParentForm, "Error", "this transaction cannot be for the same account", MessageBoxButtons.OK);
                return false;
            }
            if (string.IsNullOrWhiteSpace(Description))
            {
                FlyoutDialog.Show(this.ParentForm, "Error", "You have to enter the description", MessageBoxButtons.OK);
                return false;
            }
            if (JournalPrice == 0)
            {
                FlyoutDialog.Show(this.ParentForm, "Error", "the journal price is zero", MessageBoxButtons.OK);
                return false;
            }
            if (CurrencyID == Guid.Empty)
            {
                FlyoutDialog.Show(this.ParentForm, "Error", "the journal price is zero", MessageBoxButtons.OK);
                return false;
            }
            return base.IsReadyToSave();

        }
    }
}
