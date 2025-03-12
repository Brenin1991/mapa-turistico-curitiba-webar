# AR Mapa 3D de Curitiba

Este projeto é uma experiência de realidade aumentada (AR) para web, desenvolvida com Unity e utilizando o pacote **WebAR Foundation**. A aplicação apresenta um mapa 3D interativo de pontos turísticos de Curitiba, permitindo que os usuários explorem a cidade de uma maneira inovadora diretamente do navegador.

## Tecnologias Utilizadas
- Unity 2022.3.59f1
- WebAR Foundation
- WebGL
- Node.js (para servir a aplicação)

## Como Clonar e Rodar o Projeto

### Clonar o Repositório
```sh
git clone https://github.com/Brenin1991/mapa-turistico-curitiba-webar.git
cd mapa-turistico-curitiba-webar.git
```

### Abrir no Unity
- Abra o projeto no Unity (versão recomendada: 2022.3.59f1).
- Certifique-se de ter o pacote **WebAR Foundation** instalado via Package Manager.
- Compile a aplicação para WebGL.

### Servir a Aplicação
Para rodar a aplicação localmente, utilize o servidor Node.js criado para esse projeto. Clone e configure o servidor seguindo os passos abaixo:

```sh
git clone https://github.com/Brenin1991/ar-app-teste.git
cd ar-app-teste
```

Instalar as dependências e inicie o servidor:
```sh
npm install
node index.js
```

A aplicação estará acessível em `http://localhost:3000`.

## Aplicação Online
A experiência WebAR está disponível online:
**[AR Mapa 3D de Curitiba](https://ar-app-teste.fly.dev)**

## Vídeo demonstrativo
**[Vídeo](https://ar-app-teste.fly.dev)**