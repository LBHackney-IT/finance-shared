FROM mcr.microsoft.com/dotnet/core/sdk:3.1

# disable microsoft telematry
ENV DOTNET_CLI_TELEMETRY_OPTOUT='true'

ARG LBHPACKAGESTOKEN
ENV LBHPACKAGESTOKEN=$LBHPACKAGESTOKEN
WORKDIR /app

# Copy csproj and restore as distinct layers
COPY ./Hackney.Shared.Finance.sln ./
COPY ./Hackney.Shared.Finance/Hackney.Shared.Finance.csproj ./Hackney.Shared.Finance/
COPY ./Hackney.Shared.Finance.Tests/Hackney.Shared.Finance.Tests.csproj ./Hackney.Shared.Finance.Tests/
COPY /nuget.config /root/.nuget/NuGet/NuGet.Config

RUN dotnet restore ./Hackney.Shared.Finance/Hackney.Shared.Finance.csproj
RUN dotnet restore ./Hackney.Shared.Finance.Tests/Hackney.Shared.Finance.Tests.csproj

# Copy everything else and build
COPY . .

RUN dotnet build -c debug -o out Hackney.Shared.Finance.Tests/Hackney.Shared.Finance.Tests.csproj

CMD dotnet test