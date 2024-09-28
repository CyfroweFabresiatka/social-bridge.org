<script setup lang="ts">
import { useHomeQuery } from '@/data/home'

const query = useHomeQuery()
</script>

<template>
  <h1>This is an home page</h1>
  <p v-if="query.isLoading">Loading...</p>
  <p>{{query.data}}</p>
</template>

<style scoped>
</style>
