namespace Czar.Gateway.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class CzarReRouteGroupAuth
    {
        [Key]
        public int AuthId { get; set; }

        public int? GroupId { get; set; }

        public int? ReRouteId { get; set; }
    }
}
