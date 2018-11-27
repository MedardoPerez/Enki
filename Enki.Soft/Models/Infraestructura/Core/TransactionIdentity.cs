using System;

namespace ENKI.SOFT.Models.Infraestructura.Core
{
    public class TransactionIdentity
    {
        /// <summary>
        /// Identity's transaction.
        /// </summary>
        public string TransactionId { get; set; }

        /// <summary>
        /// Server's Date and Time
        /// </summary>
        public DateTime TransactionDate { get; set; }
    }
}