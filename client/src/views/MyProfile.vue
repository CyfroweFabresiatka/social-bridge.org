<script setup lang="ts">
import { getUser } from '@/store/auth'
import { ref } from 'vue'
const user = ref<string>(getUser())
</script>

<template>
  <h1>This is the profile of {{ user }}</h1>
</template>

<style scoped></style>
