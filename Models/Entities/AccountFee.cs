﻿namespace Models.Entities
{
    public partial class AccountFee : BaseEntity
    {
        public int OrgId { get; set; }
        public byte CurrencyId { get; set; }
        public int AccountId { get; set; }
        public byte AccountTypeId { get; set; }
        public decimal Fee { get; set; }

        public virtual Account Account { get; set; }
        public virtual AccountType AccountType { get; set; }
        public virtual Currency Currency { get; set; }
        public virtual Organisation Org { get; set; }
    }
}
