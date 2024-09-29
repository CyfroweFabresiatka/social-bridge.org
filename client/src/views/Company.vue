<script setup lang="ts">
import {useRoute} from 'vue-router'
import {useCompanyQuery} from '@/data/organisations'
import ProjectCard from '@/components/ProjectCard.vue'
import {tr} from "vuetify/locale";

const route = useRoute();
const slug = route.params.slug ?? '';
const {data, isLoading, error} = useCompanyQuery(<string>slug);
</script>

<template>
  <div v-if="!isLoading && !error">
    <div>
      <v-card class="mb-2 pa-8" style="border-radius:15px" variant="flat" border="border">
        <v-row>
          <v-col>
            <h1>{{ data!.name }}</h1>
            <p>{{ data!.city }}</p>
            <p class="mt-5">
              {{ data!.name }} is a leading provider of innovative technology solutions, specializing in delivering cutting-edge IT services to businesses of all sizes. We offer a wide range of services, including cloud computing, cybersecurity, software development, IT consulting, and managed services. Our team of expert engineers and consultants is dedicated to helping clients optimize their technology infrastructure, improve operational efficiency, and enhance digital transformation strategies.
            </p>
          </v-col>
          <v-col class="mt-5 ml-5">
            <h4>Obszary tematyczne</h4>
            <v-chip variant="outlined" v-for="tag in ['Education', 'Sport']" class="tag mp-3" :value="tag" color="primary">
              {{ tag }}
            </v-chip>
            <h4 class="mt-7">Wartości dla firmy</h4>
            <v-chip variant="outlined" v-for="tag in ['Money', 'Travels']" class="tag mp-3" :value="tag" color="primary">
              {{ tag }}
            </v-chip>
          </v-col>
        </v-row>
      </v-card>

      <v-card class="mb-2 pa-4" style="border-radius:15px" variant="flat" border="border">
        <h2>Projekty</h2>
        <v-carousel
            cycle
            hide-delimiters
            height="400"
        >
          <v-carousel-item><ProjectCard/></v-carousel-item>
          <v-carousel-item><ProjectCard/></v-carousel-item>
          <v-carousel-item><ProjectCard/></v-carousel-item>
        </v-carousel>
      </v-card>
    </div>
  </div>

</template>

<style scoped>

.projects {
}
</style>
