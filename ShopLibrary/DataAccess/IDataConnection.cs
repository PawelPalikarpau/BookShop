using ShopLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopLibrary
{
    public interface IDataConnection
    {
        PersonModel CreatePerson(PersonModel model);
        void CreateCategory(string newCategory);
        void CreateAuthor(AuthorModel model);
        BookModel CreateBook(BookModel model);
                
        PersonModel UpdatePerson(PersonModel model);
        List<PersonModel> GetAllPersons_ByEmail(string email);
        List<PersonModel> GetAllPersons();

        List<CategoryModel> GetAllCategories();
        List<CategoryModel> GetCategories_ByName(string newCategory);
        CategoryModel GetCategory_ByBook(BookModel book);
        void UpdateCategory(CategoryModel category);

        AuthorModel GetAuthorById(int Id);
        AuthorModel GetAuthor_ByBook(BookModel book);
        List<AuthorModel> GetAllAuthors();
        List<AuthorModel> GetAuthor_ByName(string authorFirstName, string authorLastName);
        List<BookModel> GetAuthorsBooks(AuthorModel model);
        void UpdateAuthor(AuthorModel model);

        List<BookModel> GetAllBooks();
        List<BookModel> GetBookById(BookModel bookS);
        List<BookModel> GetBookByName(string bookName);
        List<BookModel> GetBooksByCategory(CategoryModel category);
        void UpdateBook(BookModel book, AuthorModel author);

        void InsertBookCategory(BookModel book, CategoryModel category);
        void InsertAuthorBook(BookModel book, AuthorModel author);

        void PersonCartBook_Insert(PersonModel person, BookModel book);
        void PersonCartBook_DeleteBook(PersonModel person, BookModel book);
        void PersonCartBook_DeletePerson(PersonModel person);

        void PersonBoughtBooks_InsertBooks(PersonModel person, List<BookModel> bookList);

        void UpdateBookCategory(BookModel book, CategoryModel newCategory);
        void UpdateAuthorBook(BookModel book, AuthorModel author);
    }
}
