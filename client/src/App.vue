<script setup lang="ts">
import { RouterView } from 'vue-router'
</script>

<template>
  <v-app>
    <v-app-bar fixed app>
      <v-btn to='/' variant="text" color="primary">Social.Bridge</v-btn>
      <v-btn to='/news' variant="text" color="primary">menu_news</v-btn>
      <v-spacer></v-spacer>
      <v-btn class="mr-3" to='/create-project' variant="text" color="primary">menu_create_project_or_grant</v-btn>
      <v-btn to='/about' variant="text" color="primary">menu_my_profile</v-btn>
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
