namespace Czar.Gateway.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    public partial class CzarClientReRouteWhiteList
    {
        [Key]
        public int WhiteListId { get; set; }

        public int? ReRouteId { get; set; }

        public int? Id { get; set; }
    }
}
