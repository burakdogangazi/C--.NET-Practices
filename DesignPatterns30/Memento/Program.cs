﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    class Program
    {//Hafızadan gelir nesne değişikliğe uğradığı halde arzu edilirse değişikliğe uygulamadan önceki halini getirir.
        static void Main(string[] args)
        {
            Book book = new Book
            {
                Isbn = "12345",
                Title = "Sefiller",
                Author = "Victor Hugo"
            };

            book.ShowBook();
            
            CareTaker history = new CareTaker();
            history.memento = book.CreateUndo();
            book.Isbn = "54321";
            book.Title = "VICTOR HUGO";
            book.ShowBook();

            book.RestoreFromUndo(history.memento);
            book.ShowBook();

            Console.ReadLine();
        }
    }

    class Book
    {

        private string _title;
        private string _author;
        private string _ısbn;
        private DateTime _lastEdited;

        public string Title
        {
            get
            {
                return _title;
            }

            set
            {
                _title = value;
                SetLastEdited();
            }
        }

        public string Author
        {
            get
            {
                return _author;
            }

            set
            {
                _author = value;
                SetLastEdited();
            }
        }

        public string Isbn
        {
            get
            {
                return _ısbn;
            }

            set
            {
                _ısbn = value;
                SetLastEdited();
            }
        }

        private void SetLastEdited()
        {
            _lastEdited = DateTime.UtcNow;
        }

        public Memento CreateUndo()
        {
            return new Memento(_ısbn, _title, _author, _lastEdited);
        }

        public void RestoreFromUndo(Memento memento)
        {
            _title = memento.Title;
            _author = memento.Author;
            _ısbn = memento.Isbn;
            _lastEdited = memento.LastEdited;
        }

        public void ShowBook()
        {
            Console.WriteLine("{0},{1},{2} edited :{3}", Isbn, Title, Author, _lastEdited);
        }


    }

    class Memento
    {
        public string Isbn { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public DateTime LastEdited { get; set; }

        public Memento(string isbn, string title, string author,DateTime lastEdited)
        {
            Isbn = isbn;
            Title = title;
            Author = author;
            LastEdited = lastEdited;
        }

    }


    class CareTaker
    {
        public Memento memento { get; set; }
    }
}
