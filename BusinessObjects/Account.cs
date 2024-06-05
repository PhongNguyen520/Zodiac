﻿using System;
using System.Collections.Generic;

namespace BusinessObjects;

public partial class Account
{
    public string AccountId { get; set; } = null!;

    public string Username { get; set; } = null!;

    public string Password { get; set; } = null!;

    public string FullName { get; set; } = null!;

    public bool Gender { get; set; }

    public string Email { get; set; } = null!;

    public int PhoneNumber { get; set; }

    public bool IsActive { get; set; }

    public string RoleId { get; set; } = null!;

    public virtual ICollection<Message> Messages { get; set; } = new List<Message>();

    public virtual ICollection<Notification> Notifications { get; set; } = new List<Notification>();

    public virtual Role Role { get; set; } = null!;

    public virtual ICollection<Student> Students { get; set; } = new List<Student>();

    public virtual ICollection<Tutor> Tutors { get; set; } = new List<Tutor>();

    public virtual ICollection<Wallet> Wallets { get; set; } = new List<Wallet>();

    public virtual ICollection<Conversation> Conversations { get; set; } = new List<Conversation>();
}