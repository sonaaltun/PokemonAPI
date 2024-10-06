---
"🎮 Pokémon API 🐾"   ![Pikachu](https://img.icons8.com/color/48/000000/pikachu-pokemon.png)      ![Charmander](https://img.icons8.com/color/48/000000/charmander.png)    ![Squirtle](https://img.icons8.com/color/48/000000/squirtle.png)
 "Pokémon API ile kendi Pokémon dünyanızı keşfedin ve yönetin! Bu API, favori Pokémon'larınızı CRUD işlemleri ile yönetme fırsatı sunar. Eğlenceli ve renkli bir deneyim için hazır olun!"

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

