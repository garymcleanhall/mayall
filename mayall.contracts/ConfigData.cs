using System.Collections.Generic;

namespace mayall.contracts
{
    public class ConfigData
    {
        public IEnumerable<AccountData> Accounts { get; set; }
    }

    public class AccountData
    {
        public AccountType AccountType { get; set; }

        public string FriendlyName { get; set; }

        public string Server { get; set; }

        public int Port { get; set; }

        public SecurityType SecurityType { get; set; }

        public string Username { get; set; }
    }

    public enum AccountType
    {
        Imap,
        Pop3
    }

    public enum SecurityType
    {
        None,
        Ssl,
        Tls
    }
}
