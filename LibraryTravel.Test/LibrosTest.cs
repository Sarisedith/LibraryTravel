using LibraryTravel.Application.Interfaces;
using LibraryTravel.Application.Services;
using LibraryTravel.Application.ViewModels;
using LibraryTravel.Domain.Interfaces;
using LibraryTravel.Domain.Models;
using LibraryTravel.Web.Controllers;
using Moq;
using NUnit.Framework;

namespace LibraryTravel.Test
{
    public class LibrosTest
    {
        private Mock<ILibrosService> _mockLibrosServices;
        private Mock<IAutoresService> _mockAutoresServices;
        private Mock<IEditorialesService> _mockEditorialesService;
        private Mock<IAutores_Has_LibrosServices> _mockAutores_Has_LibrosServices;
        private Mock<ILibrosRepository> _mockLibrosRepository;
        Libros libros;
        [OneTimeSetUp]
        public void Setup()
        {
            _mockLibrosServices = new Mock<ILibrosService>();
            _mockLibrosRepository = new Mock<ILibrosRepository>();
            _mockAutoresServices = new Mock<IAutoresService>();
            _mockEditorialesService = new Mock<IEditorialesService>();
            _mockAutores_Has_LibrosServices = new Mock<IAutores_Has_LibrosServices>();
            libros = new Libros()
            {
                EditorialesId = 1,
                ISBN = 1,
                N_Paginas = "10",
                Sinopsis = "Test",
                Titulo = "Terror"
            };
        }

        [Test]
        public void GetLibrosControllerTest()
        {
            _mockLibrosServices.Setup(x => x.GetLibros()).ReturnsAsync(new LibrosViewModel());
            LibrosController LibrosController = new LibrosController(_mockLibrosServices.Object, _mockAutoresServices.Object,
                _mockEditorialesService.Object, _mockAutores_Has_LibrosServices.Object);
            Assert.DoesNotThrowAsync(async () => await LibrosController.Index());
        }

        [Test]
        public void CreateLibrosControllerTest()
        {
            _mockLibrosServices.Setup(x => x.CreateLibro(It.IsAny<Libros>())).ReturnsAsync(new Libros());
            LibrosController LibrosController = new LibrosController(_mockLibrosServices.Object, _mockAutoresServices.Object,
                _mockEditorialesService.Object, _mockAutores_Has_LibrosServices.Object);
            Assert.DoesNotThrowAsync(async () => await LibrosController.Create(libros, 1, 1));
        }
        [Test]
        public void EditLibrosControllerTest()
        {
            _mockLibrosServices.Setup(x => x.UpdateLibro(It.IsAny<Libros>())).ReturnsAsync(new Libros());
            LibrosController LibrosController = new LibrosController(_mockLibrosServices.Object, _mockAutoresServices.Object,
                _mockEditorialesService.Object, _mockAutores_Has_LibrosServices.Object);
            Assert.DoesNotThrowAsync(async () => await LibrosController.Edit(libros));
        }
        [Test]
        public void DeleteLibrosControllerTest()
        {
            _mockLibrosServices.Setup(x => x.DeleteLibro(It.IsAny<int>()));
            LibrosController LibrosController = new LibrosController(_mockLibrosServices.Object, _mockAutoresServices.Object,
                _mockEditorialesService.Object, _mockAutores_Has_LibrosServices.Object);
            Assert.DoesNotThrowAsync(async () => await LibrosController.Delete(libros.ISBN));
        }
        [Test]
        public void GetLibrosServiceTest()
        {
            _mockLibrosRepository.Setup(x => x.GetLibros());
            LibrosService LibrosService = new LibrosService(_mockLibrosRepository.Object);
            Assert.DoesNotThrowAsync(async () => await LibrosService.GetLibros());
        }
        [Test]
        public void CreateLibrosServiceTest()
        {
            _mockLibrosRepository.Setup(x => x.CreateLibro(It.IsAny<Libros>())).ReturnsAsync(new Libros());
            LibrosService LibrosService = new LibrosService(_mockLibrosRepository.Object);
            Assert.DoesNotThrowAsync(async () => await LibrosService.CreateLibro(libros));
        }
        [Test]
        public void EditLibrosServiceTest()
        {
            _mockLibrosRepository.Setup(x => x.UpdateLibro(It.IsAny<Libros>())).ReturnsAsync(new Libros());
            LibrosService LibrosService = new LibrosService(_mockLibrosRepository.Object);
            Assert.DoesNotThrowAsync(async () => await LibrosService.UpdateLibro(libros));
        }
        [Test]
        public void DeleteLibrosServiceTest()
        {
            _mockLibrosRepository.Setup(x => x.DeleteLibro(It.IsAny<int>()));
            LibrosService LibrosService = new LibrosService(_mockLibrosRepository.Object);
            Assert.DoesNotThrow(() => LibrosService.DeleteLibro(libros.ISBN));
        }
    }
}