<script setup lang="ts">
import { RouterView } from 'vue-router'
</script>

<template>
  <v-app>
    <v-app-bar fixed app>
      <v-btn to='/' variant="text" color="primary">{{ $t('home') }}</v-btn>
      <v-btn to='/about' variant="text" color="primary">{{ $t('about') }}</v-btn>
    </v-app-bar>
    <v-container class="main">
      <RouterView />
    </v-container>
  </v-app>
</template>

<style scoped>
.main {
  margin-top: 5rem;
}
</style>
