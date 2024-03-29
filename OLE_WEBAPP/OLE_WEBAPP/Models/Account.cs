﻿using System;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OLE_WEBAPP.Models
{
    [Table("accounts")]
    public class Account : IdentityUser<int>
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Column("username")]
        public string Username { get; set; }

        [Required]
        [EmailAddress]
        [Column("email")]
        public string Email { get; set; }

        [Column("PasswordHash")]
        public string PasswordHash { get; set; }

        [Column("salt")]
        public string Salt { get; set; }

        [Column(TypeName = "date")]
        public DateTime AccountCreationDate { get; set; }

        [Column(TypeName = "timestamp")]
        public DateTime LastLoginDate { get; set; }

        [Column("status")]
        public Status AccountStatus { get; set; }
        public enum Status { Active, Inactive }

        [Column("email_subscription")]
        public int EmailSubscription { get; set; }

        public string ConcurrencyStamp { get; set; }

        public bool EmailConfirmed { get; set; }

        public string NormalizedEmail { get; set; }

        public string PhoneNumber { get; set; }

        public string SecurityStamp { get; set; }

        public bool PhoneNumberConfirmed { get; set; }

        public int TwoFactorEnabled { get; set; }

        public override string NormalizedUserName
        {
            get => base.NormalizedUserName;
            set => base.NormalizedUserName = value.ToUpperInvariant();
        }

        // Navigation property for FriendsList
        public virtual ICollection<FriendsList> FriendsList1 { get; set; }
        public virtual ICollection<FriendsList> FriendsList2 { get; set; }

        // Navigation property for FriendRequest
        public virtual ICollection<FriendRequest> SentFriendRequests { get; set; }
        public virtual ICollection<FriendRequest> ReceivedFriendRequests { get; set; }
    }
}