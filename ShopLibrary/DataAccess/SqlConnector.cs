using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShopLibrary.Models;
using System.Data;
using Dapper;
using ShopLibrary.ValidationsAndHelpers;

namespace ShopLibrary
{
    public class SqlConnector : IDataConnection
    {
        const string database = "Books";

        public PersonModel CreatePerson(PersonModel model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(database)))
            {
                var p = new DynamicParameters();
                p.Add("@UniqueCode", model.UniqueCode);
                p.Add("@FirstName", model.FirstName);
                p.Add("@LastName", model.LastName);
                p.Add("@Password", model.Password);
                p.Add("@EmailAddress", model.EmailAddress);
                p.Add("@PhoneNumber", model.PhoneNumber);
                p.Add("@Photo", model.Photo);
                p.Add("@Money", 0.00);
                p.Add("@RegistrationDate", model.RegistrationDate);

                p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Query("dbo.spPerson_Insert", p, commandType: CommandType.StoredProcedure);

                model.Id = p.Get<int>("@id");

                return model;
            }
        }

        public void CreateCategory(string newCategory)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(database)))
            {
                var p = new DynamicParameters();
                p.Add("@Category", newCategory);

                connection.Query("dbo.spCategories_Insert", p, commandType: CommandType.StoredProcedure);
            }
        }

        public void CreateAuthor(AuthorModel model)
        {
            using(IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(database)))
            {
                var p = new DynamicParameters();
                p.Add("@FirstName", model.FirstName);
                p.Add("@LastName", model.LastName);
                p.Add("@Photo", model.Photo);

                connection.Query("dbo.spAuthor_Insert", p, commandType: CommandType.StoredProcedure);
            }
        }

        public BookModel CreateBook(BookModel model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(database)))
            {
                var p = new DynamicParameters();
                p.Add("@BookName", model.BookName);
                p.Add("@Pages", model.Pages);
                p.Add("@Price", model.Price);
                p.Add("@Description", model.Description);
                p.Add("@Photo", model.Photo);

                p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Query("dbo.spBooks_Insert", p, commandType: CommandType.StoredProcedure);

                model.Id = p.Get<int>("@id");

                return model;
            }
        }

        

        public PersonModel UpdatePerson(PersonModel model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(database)))
            {
                var p = new DynamicParameters();
                p.Add("@id", model.Id);
                p.Add("@UniqueCode", model.UniqueCode);
                p.Add("@FirstName", model.FirstName);
                p.Add("@LastName", model.LastName);
                p.Add("@Password", model.Password);
                p.Add("@EmailAddress", model.EmailAddress);
                p.Add("@Money", model.Money);
                p.Add("@PhoneNumber", model.PhoneNumber);
                p.Add("@Photo", model.Photo);
                p.Add("@RegistrationDate", model.RegistrationDate);

                connection.Query("dbo.spPerson_UpdatePerson", p, commandType: CommandType.StoredProcedure);

                return model;
            }
        }

        public List<PersonModel> GetAllPersons_ByEmail(string email)
        {
            List<PersonModel> lists = new List<PersonModel>();
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(database)))
            {
                var p = new DynamicParameters();
                p.Add("@EmailAddress", email);

                lists = connection.Query<PersonModel>("dbo.spPerson_GetAllByEmail", p, commandType: CommandType.StoredProcedure).ToList();

                if (lists.Count > 0)
                {
                    lists[0] = GetCartAuthors(lists[0], connection);
                    lists[0] = GetBoughtAuthors(lists[0], connection);
                }
            }

            return lists;
        }


        public List<PersonModel> GetAllPersons()
        {
            List<PersonModel> allPersons = new List<PersonModel>();

            using(IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(database)))
            {
                allPersons = connection.Query<PersonModel>("dbo.spPerson_GetAll", commandType: CommandType.StoredProcedure).ToList();

                return allPersons;
            }
        }
        private PersonModel GetCartAuthors(PersonModel model, IDbConnection connection)
        {
            var pm = new DynamicParameters();
            pm.Add("@PersonId", model.Id);

            List<BookModel> allBooks = connection.Query<BookModel>("dbo.spPersonCartBook_GetPersonBooks", pm, commandType: CommandType.StoredProcedure).ToList();
            model.CartAuthors = new List<AuthorModel>();
            foreach (BookModel book in allBooks)
            {
                book.Category = GetCategory_ByBook(book);
                AuthorModel a = GetAuthor_ByBook(book);
                a.Books = new List<BookModel>();

                bool isAuthorExists = model.CartAuthors.Any(item => item.Id == a.Id);
                if (isAuthorExists)
                {
                    model.CartAuthors.Find(x => x.Id == a.Id).Books.Add(book);
                }
                else
                {
                    a.Books.Add(book);
                    model.CartAuthors.Add(a);
                }
            }

            return model;
        }
        private PersonModel GetBoughtAuthors(PersonModel model, IDbConnection connection)
        {
            var p = new DynamicParameters();
            p.Add("@PersonId", model.Id);

            List<BookModel> allBooks = connection.Query<BookModel>("dbo.spPersonBoughtBooks_GetPersonBooks", p, commandType: CommandType.StoredProcedure).ToList();
            model.BoutghtAuthors = new List<AuthorModel>();
            foreach (BookModel book in allBooks)
            {
                book.Category = GetCategory_ByBook(book);
                AuthorModel a = GetAuthor_ByBook(book);
                a.Books = new List<BookModel>();

                bool isAuthorExists = model.BoutghtAuthors.Any(item => item.Id == a.Id);
                if (isAuthorExists)
                {
                    model.BoutghtAuthors.Find(x => x.Id == a.Id).Books.Add(book);
                }
                else
                {
                    a.Books.Add(book);
                    model.BoutghtAuthors.Add(a);
                }
            }

            return model;
        }



        public List<CategoryModel> GetAllCategories()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(database)))
            {
                List<CategoryModel> list = connection.Query<CategoryModel>("dbo.spCategories_GetAll", commandType: CommandType.StoredProcedure).ToList();

                return list;
            }
        }

        public List<CategoryModel> GetCategories_ByName(string newCategory)
        {
            List<CategoryModel> categories = new List<CategoryModel>();
            using(IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(database)))
            {
                var p = new DynamicParameters();
                p.Add("@Category", newCategory);

                categories = connection.Query<CategoryModel>("dbo.spCategories_GetCategoriesByName", p, commandType: CommandType.StoredProcedure).ToList();
            }
            return categories;
        }

        public CategoryModel GetCategory_ByBook(BookModel book)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(database)))
            {
                var p = new DynamicParameters();
                p.Add("@BookId", book.Id);

                List<CategoryModel> categorys = connection.Query<CategoryModel>("dbo.spCategory_GetByBook", p, commandType: CommandType.StoredProcedure).ToList();

                return categorys[0];
            }
        }

        void IDataConnection.UpdateCategory(CategoryModel category)
        {
            using(IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(database)))
            {
                var p = new DynamicParameters();
                p.Add("@id", category.Id);
                p.Add("@Category", category.Category);

                connection.Query("dbo.spCategory_Update", p, commandType: CommandType.StoredProcedure);
            }
        }



        public AuthorModel GetAuthorById(int Id)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(database)))
            {
                var p = new DynamicParameters();
                p.Add("AuthorId", Id);

                List<AuthorModel> models = connection.Query<AuthorModel>("dbo.spAuthor_GetById", p, commandType: CommandType.StoredProcedure).ToList();
                AuthorModel model = models[0];

                return model;
            }
        }

        public AuthorModel GetAuthor_ByBook(BookModel book)
        {
            using(IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(database)))
            {
                var p = new DynamicParameters();
                p.Add("@BookId", book.Id);

                List<AuthorModel> authors = connection.Query<AuthorModel>("dbo.spAuthor_GetByBook", p, commandType: CommandType.StoredProcedure).ToList();

                return authors[0];
            }
        }

        public List<AuthorModel> GetAllAuthors()
        {
            List<AuthorModel> authors = new List<AuthorModel>();

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(database)))
            {
                authors = connection.Query<AuthorModel>("dbo.spAuthors_GetAll", commandType: CommandType.StoredProcedure).ToList();

                foreach (AuthorModel author in authors)
                {
                    author.Books = GetAuthorsBooks(author);

                    foreach (BookModel book in author.Books)
                    {
                        book.Category = GetCategory_ByBook(book);
                    }
                }
            }

            return authors;
        }

        public void UpdateAuthor(AuthorModel authorModel)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(database)))
            {
                var p = new DynamicParameters();
                p.Add("@Id", authorModel.Id);
                p.Add("@FirstName", authorModel.FirstName);
                p.Add("@LastName", authorModel.LastName);
                p.Add("@Photo", authorModel.Photo);

                connection.Query("dbo.spAuthors_UpdateAuthor", p, commandType: CommandType.StoredProcedure);
            }
        }

        public List<AuthorModel> GetAuthor_ByName(string authorFirstName, string authorLastName)
        {
            List<AuthorModel> authors = new List<AuthorModel>();
            using(IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(database)))
            {
                var p = new DynamicParameters();
                p.Add("@FirstName", authorFirstName);
                p.Add("@LastName", authorLastName);

                authors = connection.Query<AuthorModel>("dbo.spAuthors_GetByName", p, commandType: CommandType.StoredProcedure).ToList();
            }
            return authors;
        }

        public List<BookModel> GetAuthorsBooks(AuthorModel model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(database)))
            {
                var p = new DynamicParameters();
                p.Add("@AuthorId", model.Id);

                List<BookModel> books = connection.Query<BookModel>("dbo.spAuthors_GetBooks", p, commandType: CommandType.StoredProcedure).ToList();

                return books;
            }
        }



        public List<BookModel> GetAllBooks()
        {
            List<BookModel> books;

            using(IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(database)))
            {
                books = connection.Query<BookModel>("dbo.spBooks_GetAll", commandType: CommandType.StoredProcedure).ToList();
            }

            return books;
        }

        public List<BookModel> GetBookById(BookModel book)
        {
            List<BookModel> bookList = new List<BookModel>();

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(database)))
            {
                var p = new DynamicParameters();
                p.Add("@Id", book.Id);

                bookList = connection.Query<BookModel>("dbo.spBooks_GetById", p, commandType: CommandType.StoredProcedure).ToList();

                return bookList;
            }
        }

        public List<BookModel> GetBookByName(string bookName)
        {
            List<BookModel> list = new List<BookModel>();

            using(IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(database)))
            {
                var p = new DynamicParameters();
                p.Add("@BookName", bookName);

                list = connection.Query<BookModel>("dbo.spBooks_GetByName", p, commandType: CommandType.StoredProcedure).ToList();

                return list;
            }
        }

        public List<BookModel> GetBooksByCategory(CategoryModel category)
        {
            using(IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(database)))
            {
                var p = new DynamicParameters();
                p.Add("@CategoryId", category.Id);

                List<BookModel> books = connection.Query<BookModel>("dbo.spBooks_GetByCategory", p, commandType: CommandType.StoredProcedure).ToList();

                return books;
            }
        }

        public void UpdateBook(BookModel book, AuthorModel author)
        {
            using(IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(database)))
            {
                var p = new DynamicParameters();
                p.Add("@Id", book.Id);
                p.Add("@BookName", book.BookName);
                p.Add("@Pages", book.Pages);
                p.Add("@Price", book.Price);
                p.Add("@Description", book.Description);
                p.Add("@Photo", book.Photo);

                connection.Query("dbo.spBook_UpdateBook", p, commandType: CommandType.StoredProcedure);
            }
        }



        public void InsertBookCategory(BookModel book, CategoryModel category)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(database)))
            {
                var p = new DynamicParameters();
                p.Add("@BookId", book.Id);
                p.Add("@CategoryId", category.Id);

                connection.Query("dbo.spBookCategory_Insert", p, commandType: CommandType.StoredProcedure);
            }
        }

        public void InsertAuthorBook(BookModel book, AuthorModel author)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(database)))
            {
                var p = new DynamicParameters();
                p.Add("@AuthorId", author.Id);
                p.Add("@BookId", book.Id);

                connection.Query("dbo.spAuthorBook_Insert", p, commandType: CommandType.StoredProcedure);
            }
        }



        public void PersonCartBook_Insert(PersonModel person, BookModel book)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(database)))
            {
                var p = new DynamicParameters();
                p.Add("@PersonId", person.Id);
                p.Add("@BookId", book.Id);

                connection.Query("dbo.spPersonCartBook_Insert", p, commandType: CommandType.StoredProcedure);
            }
        }

        public void PersonCartBook_DeleteBook(PersonModel person, BookModel book)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(database)))
            {
                var p = new DynamicParameters();
                p.Add("@PersonId", person.Id);
                p.Add("@BookId", book.Id);

                connection.Query("dbo.spPersonCartBook_DeleteBook", p, commandType: CommandType.StoredProcedure);
            }
        }

        public void PersonCartBook_DeletePerson(PersonModel person)
        {
            using(IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(database)))
            {
                var p = new DynamicParameters();
                p.Add("@PersonId", person.Id);

                connection.Query("dbo.spPersonCartBook_DeletePerson", p, commandType: CommandType.StoredProcedure);
            }
        }


        
        public void PersonBoughtBooks_InsertBooks(PersonModel person, List<BookModel> bookList)
        {
            using(IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(database)))
            {
                foreach (BookModel book in bookList)
                {
                    var p = new DynamicParameters();
                    p.Add("@PersonId", person.Id);
                    p.Add("@BookId", book.Id);

                    connection.Query("dbo.spPersonBoughtBooks_InsertBooks", p, commandType: CommandType.StoredProcedure);
                }
            }
        }



        void IDataConnection.UpdateBookCategory(BookModel book, CategoryModel newCategory)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(database)))
            {
                var p = new DynamicParameters();
                p.Add("@BookId", book.Id);
                p.Add("@NewCategoryId", newCategory.Id);

                connection.Query("dbo.spBookCategory_Update", p, commandType: CommandType.StoredProcedure);
            }
        }

        void IDataConnection.UpdateAuthorBook(BookModel book, AuthorModel author)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(database)))
            {
                var p = new DynamicParameters();
                p.Add("@BookId", book.Id);
                p.Add("@AuthorId", author.Id);

                connection.Query("dbo.spAuthorBook_Update", p, commandType: CommandType.StoredProcedure);
            }
        }
    }
}
