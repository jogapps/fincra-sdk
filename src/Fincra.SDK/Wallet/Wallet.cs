namespace Fincra.SDK
{
    public class WalletParams
    {
        public string? Business { get; set; }

        public string? Reference { get; set; }

        public int? Page { get; set; }

        public int? PerPage { get; set; }
    }

    public class WalletLogParams
    {
        public string? Business { get; set; }

        public string? Amount { get; set; }

        public string? Action { get; set; }

        public int? Page { get; set; }

        public int? PerPage { get; set; }
    }
}

