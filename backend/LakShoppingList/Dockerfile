# Use full SDK (for now - simple version)
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build

WORKDIR /app

# Copy everything
COPY . .

# Build and publish app
RUN dotnet publish -c Release -o out

# Run the app
CMD ["dotnet", "out/LakShoppingList.dll", "--urls", "http://0.0.0.0:5000"]
