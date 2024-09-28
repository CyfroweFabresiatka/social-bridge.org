<script setup lang="ts">
import { RouterView } from 'vue-router'
import UserMenu from './views/UserMenu.vue'
</script>

<template>
  <v-app>
    <v-app-bar fixed app>
      <v-btn to="/" variant="text" color="primary"> {{ $t('menu.app_name') }} </v-btn>
      <v-btn to="/organisations" variant="text" color="primary">
        {{ $t('menu.organisations') }}
      </v-btn>
      <v-btn to="/blog" variant="text" color="primary"> {{ $t('menu.blog') }} </v-btn>
      <v-spacer></v-spacer>
      <v-btn class="mr-3" to="/create-project" variant="text" color="primary">
        {{ $t('menu.create_project_or_grant') }}</v-btn
      >
      <user-menu></user-menu>
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
