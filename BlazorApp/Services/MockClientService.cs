// Services/MockClientService.cs
using BlazorApp.Models;

public class MockClientService
{
    private List<Client> _clients = new();
    private int _nextId = 1;

    public MockClientService()
    {
        _clients.AddRange(new[]
        {
            new Client { Id = _nextId++, Name = "Alice", Email = "alice@example.com", Phone = "123456789" },
            new Client { Id = _nextId++, Name = "Bob", Email = "bob@example.com", Phone = "987654321" }
        });
    }


    public Task<List<Client>> GetAllAsync()
    {
        return Task.FromResult(_clients);
    }

    public Task<Client?> GetByIdAsync(int id)
    {
        var client = _clients.FirstOrDefault(c => c.Id == id);
        return Task.FromResult(client);
    }

    public Task AddAsync(Client client)
    {
        client.Id = _nextId++;
        _clients.Add(client);
        return Task.CompletedTask;
    }

    public Task UpdateAsync(Client client)
    {
        var index = _clients.FindIndex(c => c.Id == client.Id);
        if (index >= 0)
        {
            _clients[index] = client;
        }
        return Task.CompletedTask;
    }

    public Task DeleteAsync(int id)
    {
        _clients.RemoveAll(c => c.Id == id);
        return Task.CompletedTask;
    }
}
