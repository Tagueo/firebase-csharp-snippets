﻿using System;
using System.Collections.Generic;

namespace FirebaseSnippets.Data
{
    public enum Status
    {
        BANNED,
        ADMIN,
        INACTIVE,
        ACTIVE
    }
    
    public class User
    {
        private string username;
        private string email;
        private DateTimeOffset birthdate;
        private List<string> likedNews;
        private List<object> matchHistory;
        private int elo;
        private DateTimeOffset registerDate;
        private Status status;
        private List<object> items;
        private int level;

        public User(string username,
            string email, 
            DateTimeOffset birthdate, 
            List<string> likedNews, 
            List<object> matchHistory,
            int elo,
            DateTimeOffset registerDate,
            Status status,
            List<object> items,
            int level)
        {
            this.username = username;
            this.birthdate = birthdate;
            this.likedNews = likedNews;
            this.matchHistory = matchHistory;
            this.elo = elo;
            this.email = email;
            this.registerDate = registerDate;
            this.status = status;
            this.items = items;
            this.level = level;
        }

        public int Level => level;

        public string Username => username;

        public string Email => email;

        public DateTimeOffset Birthdate => birthdate;

        public List<string> LikedNews => likedNews;

        public List<object> MatchHistory => matchHistory;

        public int Elo => elo;

        public DateTimeOffset RegisterDate => registerDate;

        public Status Status => status;

        public List<object> Items => items;
    }
}