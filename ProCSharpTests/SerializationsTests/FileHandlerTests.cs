using System.Text.Json;
using ProSharp.Serializations;
using System.IO.Abstractions;
using System.IO.Abstractions.TestingHelpers;

namespace ProCSharpTests.SerializationsTests;

public class FileHandlerTests
{
    private readonly IFileSystem _fileSystem;
    
    private class TestClass
    {
        public int Id { get; set; }
        public string? Name { get; set; }
    }

    private static TestClass Get()
    {
        return new TestClass { Id = 1, Name = "Test" };
    }

    private static string GetFileName()
    {
        return "TestData.json";
    }

    public FileHandlerTests()
    {
        _fileSystem = new MockFileSystem();
    }

    [Test]
    public void SaveAsJsonFormat_ShouldSaveFileWithoutOptions()
    {
        // Arrange
        var testObject = Get();
        
        // Act
        var fileHandler = new FileHandler<TestClass>(_fileSystem);
        fileHandler.SaveAsJsonFormat(testObject,  GetFileName());
        var savedFile = _fileSystem.File.ReadAllText( GetFileName());
        
        // Assert
        var expectedJson = JsonSerializer.Serialize(testObject);
        Assert.That(expectedJson, Is.EqualTo(savedFile));
    }
    
    [Test]
    public void SaveAsJsonFormat_ShouldSaveFileWithOptions()
    {
        // Arrange
        var testObject = Get();

        // Act
        var fileHandler = new FileHandler<TestClass>(_fileSystem);
        fileHandler.SaveAsJsonFormat(testObject, GetFileName(), includeOptions: true);
        var savedFile = _fileSystem.File.ReadAllText( GetFileName());

        // Assert
        var options = new JsonSerializerOptions
        {
            IncludeFields = true,
            WriteIndented = true
        };
        var expectedJson = JsonSerializer.Serialize(testObject, options);
        Assert.That(expectedJson, Is.EqualTo(savedFile));
    }
    
    [Test]
    public void Load_ShouldLoadFile()
    {
        // Arrange
        var testObject = Get();
        var json = JsonSerializer.Serialize(testObject);
        _fileSystem.File.WriteAllText( GetFileName(), json);

        // Act
        var fileHandler = new FileHandler<TestClass>(_fileSystem);
        var loadedObject = fileHandler.Load( GetFileName());

        // Assert
        Assert.That(loadedObject, Is.Not.Null);
        Assert.Multiple(() =>
        {
            Assert.That(loadedObject?.Id, Is.EqualTo(testObject.Id));
            Assert.That(loadedObject?.Name, Is.EqualTo(testObject.Name));
        });
    }
    
    [Test]
    public void Load_ShouldReturnDefaultForEmptyFile()
    {
        // Arrange
        const string emptyFileName = "empty.json";
        _fileSystem.File.WriteAllText(emptyFileName, string.Empty);

        // Act
        var fileHandler = new FileHandler<TestClass>(_fileSystem);
        var loadedObject = fileHandler.Load(emptyFileName);

        // Assert
        Assert.That(loadedObject, Is.Not.Null);
        Assert.Multiple(() =>
        {
            Assert.That(loadedObject?.Id, Is.EqualTo(0));
            Assert.That(loadedObject?.Name, Is.EqualTo(default));
        });
    }
    
    
}