<script setup lang="ts">

</script>

<template>
  <v-card
      class="mx-auto"
      max-width="344"
  >
    <v-img
        height="200px"
        src="https://images.unsplash.com/photo-1607227063002-677dc5fdf96f?q=80&w=1974&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D"
        cover
    ></v-img>

    <v-card-title>
      Szlachetna paczka 2024
    </v-card-title>

    <v-card-subtitle>
      <div>
        <v-chip variant="outlined" v-for="tag in ['Education', 'Sport']" class="tag mp-3" :value="tag" color="primary">
          {{ tag }}
        </v-chip>
      </div>

      <div class="mt-5">
      Było fajnie!
      </div>
    </v-card-subtitle>

    <v-card-actions>
      <v-btn
          color="orange-lighten-2"
          text="Zobacz więcej"
      ></v-btn>

      <v-spacer></v-spacer>
      
    </v-card-actions>

    <v-expand-transition>
      <div>
        <v-divider></v-divider>

        <v-card-text>
          I'm a thing. But, like most politicians, he promised more than he could deliver. You won't have time
          for sleeping, soldier, not with all the bed making you'll be doing. Then we'll go with that data
          file! Hey, you add a one and two zeros to that or we walk! You're going to do his laundry? I've got
          to find a way to escape.
        </v-card-text>
      </div>
    </v-expand-transition>
  </v-card>
</template>

<style scoped lang="scss">
</style>
