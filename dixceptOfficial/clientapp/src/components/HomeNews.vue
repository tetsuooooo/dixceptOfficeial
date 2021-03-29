<template>
    <v-row class="mt-3">
        <v-divider></v-divider>
        <v-col cols="12" class="text-h2 text-center">News</v-col>
        <v-row class="mt-2">
            <v-col cols="6" sm="3" v-for="(n, index) in news" :key="index">
                <v-card class="mx-auto" max-width="344">
                    <v-img src="../assets/dixsept_header_logo.png" height="200px" contain></v-img>
                    <v-card-subtitle>{{n.date}}</v-card-subtitle>
                    <v-card-title>{{n.title}}</v-card-title>
                    <v-card-actions>
                        <v-btn color="green darken-4" text>ViewMore</v-btn>
                        <v-spacer></v-spacer>
                        <v-btn icon @click="n.show = !n.show">
                            <v-icon>{{ n.show ? 'mdi-chevron-up' : 'mdi-chevron-down' }}</v-icon>
                        </v-btn>
                    </v-card-actions>
                    <v-expand-transition>
                        <div v-show="n.show">
                            <v-divider></v-divider>
                            <v-card-text>
                            サンプル
                            </v-card-text>
                        </div>
                    </v-expand-transition>
                </v-card>
            </v-col>
        </v-row>
    </v-row>
</template>

<script lang="ts">
import { Component, Vue } from 'vue-property-decorator';

@Component({
  components: {
   
  },
})
export default class Home extends Vue {
  data(){
      return{
          news:{
              one: {
                  date: '2020/12/31',
                  title: "本日の活動について",
                  show: false
              },
              two: {
                  date: '2020/12/31',
                  title: "本日の活動について",
                  show: false
              },
              three: {
                  date: '2020/12/31',
                  title: "本日の活動について",
                  show: false
              },
              four: {
                  date: '2020/12/31',
                  title: "本日の活動について",
                  show: false
              },
              five: {
                  date: '2020/12/31',
                  title: "本日の活動について",
                  show: false
              },
              six: {
                  date: '2020/12/31',
                  title: "本日の活動について",
                  show: false
              },
              seven: {
                  date: '2020/12/31',
                  title: "本日の活動について",
                  show: false
              },
              eight: {
                  date: '2020/12/31',
                  title: "本日の活動について",
                  show: false
              },
          }
      }
  }
}
</script>

<style scoped>
  
</style>
