﻿namespace UniversityApi.UsersModule.Domain;

public class User
{
    public int UserId { get; init; }
    public required string Username { get; init; }
    public required string Email { get; init; }
    public required string Password { get; init; }
}