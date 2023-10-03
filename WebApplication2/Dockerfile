FROM mcr.microsoft.com/dotnet/aspnet:6.0-alpine3.17

WORKDIR /app
COPY /bin/Release/net6.0/publish .

ENV DOTNET_SYSTEM_GLOBALIZATION_INVARIANT=false
ENV DOTNET_RUNNING_IN_CONTAINER=true
RUN apk add --no-cache tzdata icu-libs krb5-libs libgcc libintl libssl1.1 libstdc++ zlib openssl

ENTRYPOINT ["dotnet", "WebApplication2.dll"]

##Build project with the following build command for this docker file.
# sudo dotnet publish --configuration release --no-self-contained --runtime linux-musl-x64