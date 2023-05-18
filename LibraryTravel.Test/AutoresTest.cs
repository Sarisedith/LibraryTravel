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
    public class AutoresTest
    {
        private Mock<IAutoresService> _mockAutoresServices;
        private Mock<IAutoresRepository> _mockAutoresRepository;
        Autores autores;
        [OneTimeSetUp]
        public void Setup()
        {
            _mockAutoresServices = new Mock<IAutoresService>();
            _mockAutoresRepository = new Mock<IAutoresRepository>();
            autores = new Autores()
            {
                Id = 1,
                Nombre = "test1",
                Apellido = "test2",
            };
        }

        [Test]
        public void GetAutoresControllerTest()
        {
            _mockAutoresServices.Setup(x => x.GetAutores()).ReturnsAsync(new AutoresViewModel());
            AutoresController autoresController = new AutoresController(_mockAutoresServices.Object);
            Assert.DoesNotThrowAsync(async () => await autoresController.Index());
        }

        [Test]
        public void CreateAutoresControllerTest()
        {
            _mockAutoresServices.Setup(x => x.CreateAutores(It.IsAny<Autores>())).ReturnsAsync(new Autores());
            AutoresController autoresController = new AutoresController(_mockAutoresServices.Object);
            Assert.DoesNotThrowAsync(async () => await autoresController.Create(autores));
        }
        [Test]
        public void EditAutoresControllerTest()
        {
            _mockAutoresServices.Setup(x => x.UpdateAutores(It.IsAny<Autores>())).ReturnsAsync(new Autores());
            AutoresController autoresController = new AutoresController(_mockAutoresServices.Object);
            Assert.DoesNotThrowAsync(async () => await autoresController.Edit(autores));
        }
        [Test]
        public void DeleteAutoresControllerTest()
        {
            _mockAutoresServices.Setup(x => x.DeleteAutor(It.IsAny<int>()));
            AutoresController autoresController = new AutoresController(_mockAutoresServices.Object);
            Assert.DoesNotThrowAsync(async () => await autoresController.Delete(autores.Id));
        }
        [Test]
        public void GetAutoresServiceTest()
        {
            _mockAutoresRepository.Setup(x => x.GetAutores());
            AutoresService autoresService = new AutoresService(_mockAutoresRepository.Object);
            Assert.DoesNotThrowAsync(async () => await autoresService.GetAutores());
        }
        [Test]
        public void CreateAutoresServiceTest()
        {
            _mockAutoresRepository.Setup(x => x.CreateAutores(It.IsAny<Autores>())).ReturnsAsync(new Autores());
            AutoresService autoresService = new AutoresService(_mockAutoresRepository.Object);
            Assert.DoesNotThrowAsync(async () => await autoresService.CreateAutores(autores));
        }
        [Test]
        public void EditAutoresServiceTest()
        {
            _mockAutoresRepository.Setup(x => x.UpdateAutores(It.IsAny<Autores>())).ReturnsAsync(new Autores());
            AutoresService autoresService = new AutoresService(_mockAutoresRepository.Object);
            Assert.DoesNotThrowAsync(async () => await autoresService.UpdateAutores(autores));
        }
        [Test]
        public void DeleteAutoresServiceTest()
        {
            _mockAutoresRepository.Setup(x => x.DeleteAutor(It.IsAny<int>()));
            AutoresService autoresService = new AutoresService(_mockAutoresRepository.Object);
            Assert.DoesNotThrow(() => autoresService.DeleteAutor(autores.Id));
        }
    }
}