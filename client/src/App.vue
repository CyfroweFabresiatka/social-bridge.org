<script setup lang="ts">
import { RouterView } from 'vue-router'
</script>

<template>
  <v-app>
    <v-app-bar fixed app>
      <v-btn to='/' variant="text" color="primary"> {{ $t('menu.app_name') }} </v-btn>
      <v-btn to='/organisations' variant="text" color="primary"> {{ $t('menu.organisations') }} </v-btn>
      <v-btn to='/blog' variant="text" color="primary"> {{ $t('menu.blog') }} </v-btn>
      <v-spacer></v-spacer>
      <v-btn class="mr-3" to='/create-project' variant="text" color="primary"> {{ $t('menu.create_project_or_grant') }}</v-btn>
      <v-btn to='/my-profile' variant="text" color="primary"> {{ $t('menu.my_profile') }}</v-btn>
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
