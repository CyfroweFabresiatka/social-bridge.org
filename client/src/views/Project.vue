<script setup lang="ts">
import { useRoute } from 'vue-router'
import { useProjectQuery } from '@/data/project'

const route = useRoute();
const slug = route.params.slug;
const { data, isLoading } = useProjectQuery(slug)

</script>

<template>
  <h1>This is about project {{slug}}</h1>
  <v-btn>
    {{ $t("project.button_interested")}}
  </v-btn>
</template>

<style scoped>
</style>
