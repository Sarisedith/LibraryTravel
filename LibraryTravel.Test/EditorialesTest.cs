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
    public class EditorialesTest
    {
        private Mock<IEditorialesService> _mockEditorialesServices;
        private Mock<IEditorialesRepository> _mockEditorialesRepository;
        Editoriales editoriales;
        [OneTimeSetUp]
        public void Setup()
        {
            _mockEditorialesServices = new Mock<IEditorialesService>();
            _mockEditorialesRepository = new Mock<IEditorialesRepository>();
            editoriales = new Editoriales()
            {
                Id = 1,
                Nombre = "test1",
                Sede = "1"
            };
        }

        [Test]
        public void GetEditorialesControllerTest()
        {
            _mockEditorialesServices.Setup(x => x.GetEditoriales()).ReturnsAsync(new EditorialesViewModel());
            EditorialesController EditorialesController = new EditorialesController(_mockEditorialesServices.Object);
            Assert.DoesNotThrowAsync(async () => await EditorialesController.Index());
        }

        [Test]
        public void CreateEditorialesControllerTest()
        {
            _mockEditorialesServices.Setup(x => x.CreateEditoriales(It.IsAny<Editoriales>())).ReturnsAsync(new Editoriales());
            EditorialesController EditorialesController = new EditorialesController(_mockEditorialesServices.Object);
            Assert.DoesNotThrowAsync(async () => await EditorialesController.Create(editoriales));
        }
        [Test]
        public void EditEditorialesControllerTest()
        {
            _mockEditorialesServices.Setup(x => x.UpdateEditoriales(It.IsAny<Editoriales>())).ReturnsAsync(new Editoriales());
            EditorialesController EditorialesController = new EditorialesController(_mockEditorialesServices.Object);
            Assert.DoesNotThrowAsync(async () => await EditorialesController.Edit(editoriales));
        }
        [Test]
        public void DeleteEditorialesControllerTest()
        {
            _mockEditorialesServices.Setup(x => x.DeleteEditoriales(It.IsAny<int>()));
            EditorialesController EditorialesController = new EditorialesController(_mockEditorialesServices.Object);
            Assert.DoesNotThrowAsync(async () => await EditorialesController.Delete(editoriales.Id));
        }
        [Test]
        public void GetEditorialesServiceTest()
        {
            _mockEditorialesRepository.Setup(x => x.GetEditoriales());
            EditorialesService EditorialesService = new EditorialesService(_mockEditorialesRepository.Object);
            Assert.DoesNotThrowAsync(async () => await EditorialesService.GetEditoriales());
        }
        [Test]
        public void CreateEditorialesServiceTest()
        {
            _mockEditorialesRepository.Setup(x => x.CreateEditoriales(It.IsAny<Editoriales>())).ReturnsAsync(new Editoriales());
            EditorialesService EditorialesService = new EditorialesService(_mockEditorialesRepository.Object);
            Assert.DoesNotThrowAsync(async () => await EditorialesService.CreateEditoriales(editoriales));
        }
        [Test]
        public void EditEditorialesServiceTest()
        {
            _mockEditorialesRepository.Setup(x => x.UpdateEditoriales(It.IsAny<Editoriales>())).ReturnsAsync(new Editoriales());
            EditorialesService EditorialesService = new EditorialesService(_mockEditorialesRepository.Object);
            Assert.DoesNotThrowAsync(async () => await EditorialesService.UpdateEditoriales(editoriales));
        }
        [Test]
        public void DeleteEditorialesServiceTest()
        {
            _mockEditorialesRepository.Setup(x => x.DeleteEditoriales(It.IsAny<int>()));
            EditorialesService EditorialesService = new EditorialesService(_mockEditorialesRepository.Object);
            Assert.DoesNotThrow(() => EditorialesService.DeleteEditoriales(editoriales.Id));
        }
    }
}