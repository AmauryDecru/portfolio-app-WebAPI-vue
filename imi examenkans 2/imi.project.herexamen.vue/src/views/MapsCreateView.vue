<template>
  <Navbar/>
  <body class="body-bg min-h-screen pt-12 md:pt-20 pb-6 px-2 md:px-0">
  <main class="bg-white max-w-lg mx-auto p-8 md:p-12 my-10 rounded-lg shadow-2xl">
    <section>
      <h3 class="font-bold text-gray-800 text-2xl font-Exo">Create New Map</h3>
    </section>
    <section class="mt-10">
      <form class="flex flex-col" @submit.prevent="CreateMap" method="POST" action="#">
        <div class="mb-6 pt-3 bg-gray-200">
          <label class="block text-gray-700 text-sm font-bold font-Exo mb-2 ml-3" for="codename">Map Name</label>
          <input type="text" id="codename" v-model="map.name" required class="bg-gray-200 rounded w-full text-gray-700 focus:outline-none border-b-4 border-gray-300 focus:border-yellow-500 transition:duration-500 px-3 pb-3">
        </div>
        <button class="bg-yellow-500 font-Exo h-8 hover:bg-yellow-600 text-gray-600 rounded shadow-lg hover:shadow-xl transition:duration-200" type="submit">Add Map</button>
      </form>
    </section>
    <div v-if="errorMessage" class="max-w-lg mx-auto text-center mt-12 mb-6">
      <p class="text-red-600">{{ errorMessage }}</p>
    </div>
  </main>
  </body>
</template>

<script>
import Navbar from "@/components/Navbar";
import MapService from "@/Services/MapService";
import router from "@/router";

export default {
  name: "MapsCreateView.vue",
  data() {
    return {
      map: {},
      submitted: false,
      errorMessage: '',
    }
  },

  methods: {
    CreateMap() {
      var data = {
        name: this.map.name,
      };
      MapService.create(data).then(response => {
        console.log(response.data);
        this.newMap();
        router.push('/Maps')

      }).catch(ex => {
        this.errorMessage = ex;
      });
    },

    newMap() {
      this.errorMessage = '';
      this.map = {};
    },
  },

  mounted() {
  },

  components: {
    Navbar,
  }
}
</script>

<style scoped>

</style>