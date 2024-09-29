<script setup lang="ts">
import {useRoute} from 'vue-router'
import {useNgoQuery} from '@/data/organisations'
import ProjectCard from '@/components/ProjectCard.vue'

const route = useRoute();
const slug = route.params.slug ?? '';
const {data, isLoading, error} = useNgoQuery(<string>slug);
</script>

<template>
  <div v-if="!isLoading && !error">
    <div>
      <v-card class="mb-2 pa-4" style="border-radius:15px" variant="flat" border="border">
        <v-row>
          <v-col>
            <v-card-title>{{ data!.name }}</v-card-title>
            <v-card-text class="mb-4">{{ data!.name }}{{ data!.city }}


              <div class="mt-4">
                {{ data!.name }} is a globally recognized non-governmental organization (NGO) that focuses on the protection and promotion of human rights. Founded in 1961, its mission is to campaign for a world where every person enjoys the rights enshrined in the Universal Declaration of Human Rights and other international human rights standards.

                {{ data!.name }} works to investigate and expose human rights abuses, such as unlawful detentions, torture, and discrimination, and it mobilizes public opinion to apply pressure on governments and other powerful institutions to stop these violations. The organization also advocates for justice, freedom, and dignity for all people, regardless of their race, nationality, gender, or political beliefs.
              </div>
              <div class="mt-3">
                <ul>
                  <li>{{ data!.name }} Linkedin</li>
                  <li>{{ data!.name }} email</li>
                  <li>{{ data!.name }} phone</li>
                </ul>
              </div>
            </v-card-text>
           
          </v-col>
          <v-col>
            <v-chip variant="outlined" v-for="tag in data!.tags" class="tag" :value="tag" color="primary">
              {{ tag }}
            </v-chip>
          </v-col>
        </v-row>
      </v-card>

      <v-card class="mb-2 pa-4" style="border-radius:15px" variant="flat" border="border">
        <h2>Nasze zrealizowane projekty</h2>
        <v-row class="mt-4">
          <v-col col="3"><ProjectCard/></v-col>
          <v-col col="3"><ProjectCard/></v-col>
          <v-col col="3"><ProjectCard/></v-col>
          <v-col col="3"><ProjectCard/></v-col>
        </v-row>
        <v-row class="mt-4">
          <v-col col="3"><ProjectCard/></v-col>
          <v-col col="3"><ProjectCard/></v-col>
          <v-col col="3"><ProjectCard/></v-col>
          <v-col col="3"><ProjectCard/></v-col>
        </v-row>
      </v-card>
      
      
    </div>
  </div>

</template>

<style scoped>
</style>
