<script setup lang="ts">
import { useRoute } from 'vue-router'
import { useProjectQuery } from '@/data/project/project'

const route = useRoute();
const slug = route.params.slug ?? '';
const { data, isLoading, error } = useProjectQuery(<string>slug)

</script>

<template>
  <div v-if="!isLoading && !error">
    <h1>This is about project {{slug}}</h1>
    {{data!.name}}
    <v-btn>
      {{ $t("project.button_interested")}}
    </v-btn>
  </div>
  
</template>

<style scoped>
</style>
