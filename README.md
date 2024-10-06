---
title: "🎮 Pokémon API 🐾"
description: "Pokémon API ile kendi Pokémon dünyanızı keşfedin ve yönetin! Bu API, favori Pokémon'larınızı CRUD işlemleri ile yönetme fırsatı sunar. Eğlenceli ve renkli bir deneyim için hazır olun!"
sections:
  -  "🚀 Nasıl Kullanılır?"
    content: |
      1. **Depoyu Klonla** 🖥️: Bu projeyi kendi bilgisayarınıza klonlayın.
         ```bash
         git clone https://github.com/kullanici-adin/pokemon-api.git
         ```
      2. **Bağımlılıkları Yükle** 🔧: Gerekli paketleri yükleyin.
         ```bash
         dotnet restore
         ```
      3. **Veritabanını Seed Et** 🌱: Seed verilerini yükleyerek başlangıç Pokémon verisi oluşturun.
         ```bash
         dotnet run seeddata
         ```
      4. **API'yi Çalıştır** 🏃: API'yi başlatın ve Pokémon dünyasına adım atın.
         ```bash
         dotnet run
         ```

  -  "🎯 API Endpoint'leri"
     |
      - **Tüm Pokémon'ları Getir** 🐉:
        ```http
        GET /api/pokemon
        ```

      - **Belirli Bir Pokémon'u Getir** 🔍:
        ```http
        GET /api/pokemon/{id}
        ```

      - **Yeni Pokémon Ekle** 📝:
        ```http
        POST /api/pokemon
        ```

      - **Pokémon Güncelle** 🛠️:
        ```http
        PUT /api/pokemon/{id}
        ```

      - **Pokémon Sil** 🗑️:
        ```http
        DELETE /api/pokemon/{id}
        ```

      ### Pikachu ⚡
      Pikachu, elektrik tipi bir Pokémon'dur ve genellikle enerjik ve maceracı bir karakter olarak bilinir. **Elektrik şoku** yeteneğiyle rakiplerini etkisiz hale getirir.

      ![Pikachu](https://img.icons8.com/color/48/000000/pikachu-pokemon.png)

      ### Bulbasaur 🌱
      Bulbasaur, hem çimen hem de zehir tipi bir Pokémon'dur. Sırtında büyüyen bitki, güneş ışığını toplar ve bu bitki olgunlaştıkça Bulbasaur daha güçlü hale gelir.

      ![Bulbasaur](https://img.icons8.com/color/48/000000/bulbasaur.png)

      ### Charmander 🔥
      Charmander, ateş tipi bir Pokémon'dur. Kuyruğundaki alev, onun ruh halini yansıtır. Alev ne kadar parlaksa, Charmander o kadar mutlu ve enerjik demektir.

      ![Charmander](https://img.icons8.com/color/48/000000/charmander.png)

      ### Squirtle 💧
      Su tipi Pokémon olan Squirtle, kabuğuyla kendini korur ve düşmanlarına karşı **Su Tabancası** saldırısını kullanır. Dalgalar yaratma konusunda oldukça yeteneklidir.

      ![Squirtle](https://img.icons8.com/color/48/000000/squirtle.png)

  -  "🛠️ Kurulum"
    content: |
      ### 1. Bu projeyi klonlayın
      ```bash
      git clone https://github.com/kullanici-adin/pokemon-api.git
      ```

      ### 2. Bağımlılıkları yükleyin
      ```bash
      dotnet restore
      ```

      ### 3. Veritabanını Seed edin (Opsiyonel)
      ```bash
      dotnet run seeddata
      ```

      ### 4. API'yi çalıştırın
      ```bash
      dotnet run
      ```

