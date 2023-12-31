﻿using System.Security.Claims;

namespace simpleapi.Models
{
    public class User
    {
        
        public int Id { get; set; }
        public string? Email { get; set; }
        public string Username { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        public string? VerificationToken { get; set; }
        public DateTime? VerifiedAt { get; set; }
        public string? PasswordResetToken { get; set; }
        public DateTime? ResetTokenExpires { get; set; }
        
    }
}
