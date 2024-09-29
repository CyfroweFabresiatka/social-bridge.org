<script setup lang="ts">
import {useRoute} from 'vue-router'
import {useCompanyQuery} from '@/data/organisations'

const route = useRoute();
const slug = route.params.slug ?? '';
const {data, isLoading, error} = useCompanyQuery(<string>slug);
</script>

<template>
  <div v-if="!isLoading && !error">
    <div>
      <v-card class="mb-2 pa-4" style="border-radius:15px" variant="flat" border="border">
        <v-row>
          <v-col>
            <v-card-title>{{ data.name }}</v-card-title>
            <v-card-text>{{ data.ngoName }}, {{ data.city }}
            </v-card-text>
          </v-col>
          <v-col>
            <v-chip variant="outlined" v-for="tag in data.tags" class="tag" :value="tag" color="primary">
              {{ tag }}
            </v-chip>
            <v-card-text>{{ budgetDescription }}</v-card-text>
          </v-col>
        </v-row>
      </v-card>
    </div>
  </div>

</template>

<style scoped>
</style>
