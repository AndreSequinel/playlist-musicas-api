## Projeto de Console e API: Músicas e Filmes 🎵🎬

Este projeto consiste em uma aplicação de console que consome dados de músicas e filmes a partir de APIs externas e permite ao usuário navegar entre opções interativas. A aplicação permite:

1. **Exibir listas de músicas e filmes**: Os dados são organizados e exibidos por meio de filtros e ordenações utilizando LINQ.
2. **Criar uma playlist personalizada**: O usuário pode escolher músicas de uma lista e gerar um arquivo JSON exportado, que representa suas músicas favoritas.
3. **Navegação interativa**: O menu permite que o usuário escolha entre exibir músicas, filmes, criar playlists ou sair da aplicação.

### Funcionalidades

- **Listar músicas e filmes**: Os dados são obtidos de APIs públicas, filtrados e exibidos ordenadamente.
- **Exportar playlist em JSON**: O usuário pode criar uma playlist de até 5 músicas e salvá-la como um arquivo JSON.
- **Filtros personalizados**: A aplicação utiliza o poder do LINQ para ordenar e filtrar as listas de músicas e filmes de acordo com critérios específicos.

### Tecnologias Utilizadas

- C#
- LINQ
- HttpClient para requisições de API
- System.Text.Json para serialização/deserialização JSON
