FROM mono:latest

RUN apt-get update
RUN apt-get install wget
RUN wget https://packages.microsoft.com/config/debian/11/packages-microsoft-prod.deb -O packages-microsoft-prod.deb -P /tmp
RUN dpkg -i /tmp/packages-microsoft-prod.deb
RUN rm /tmp/packages-microsoft-prod.deb
# RUN wget https://dot.net/v1/dotnet-install.sh -P /tmp/
# RUN chmod +x /tmp/dotnet-install.sh
# RUN bash /tmp/dotnet-install.sh


RUN mono --version
# RUN msbuild MySolution.sln
# RUN mono MyConsoleApp.exe


# FROM debian:buster-slim

# MAINTAINER Jo Shields <jo.shields@xamarin.com>
# MAINTAINER Alexander Köplinger <alkpli@microsoft.com>

# ENV MONO_VERSION 6.10.0.104

# RUN apt-get update \
#   && apt-get install -y --no-install-recommends gnupg dirmngr ca-certificates \
#   && rm -rf /var/lib/apt/lists/* \
#   && export GNUPGHOME="$(mktemp -d)" \
#   && gpg --batch --keyserver hkp://keyserver.ubuntu.com:80 --recv-keys 3FA7E0328081BFF6A14DA29AA6A19B38D3D831EF \
#   && gpg --batch --export --armor 3FA7E0328081BFF6A14DA29AA6A19B38D3D831EF > /etc/apt/trusted.gpg.d/mono.gpg.asc \
#   && gpgconf --kill all \
#   && rm -rf "$GNUPGHOME" \
#   && apt-key list | grep Xamarin \
#   && apt-get purge -y --auto-remove gnupg dirmngr

# RUN echo "deb https://download.mono-project.com/repo/debian stable-buster/snapshots/$MONO_VERSION main" > /etc/apt/sources.list.d/mono-official-stable.list \
#   && apt-get update \
#   && apt-get install -y mono-runtime \
#   && rm -rf /var/lib/apt/lists/* /tmp/*