<template>
    <div>
      <v-row>
        <v-col cols="12">
          <v-img :src="require('../assets/NoImg.png')" width="100%" height="40vh"></v-img>
        </v-col>
      </v-row>
      <v-row justify="center" class="mt-5">
        <v-col cols="11">
          <v-card elevation="6">
            <v-card-title>チーム概要</v-card-title>
            <v-simple-table>
              <template v-slot:default>
                <tbody>
                  <tr
                    v-for="item in overView"
                    :key="item.name"
                  >
                    <td>{{ item.item }}</td>
                    <td>{{ item.value }}</td>
                  </tr>
                </tbody>
              </template>
            </v-simple-table>
          </v-card>
        </v-col>
      </v-row>
      <v-row justify="center">
        <v-col cols="11">
          <v-card>
            <v-card-title>ユニフォーム</v-card-title>
            <v-row justify="center">
              <v-col cols="6">
                <v-card-subtitle>フィールド1st</v-card-subtitle>
                <v-img :src="require('../assets/NoImg.png')" contain width="80%" height="300"></v-img>
              </v-col>
              <v-col cols="6">
                <v-card-subtitle>フィールド2nd</v-card-subtitle>
                <v-img :src="require('../assets/NoImg.png')" contain width="80%" height="300"></v-img>
              </v-col>
              <v-col cols="6">
                <v-card-subtitle>ゴレイロ1st</v-card-subtitle>
                <v-img :src="require('../assets/NoImg.png')" contain width="80%" height="300"></v-img>
              </v-col>
              <v-col cols="6">
                <v-card-subtitle>ゴレイロ2nd</v-card-subtitle>
                <v-img :src="require('../assets/NoImg.png')" contain width="80%" height="300"></v-img>
              </v-col>
            </v-row>
          </v-card>
        </v-col>
      </v-row>
      <v-row justify="center">
        <v-col cols="11">
          <v-card>
            <v-card-title>戦績</v-card-title>
            <v-row>
              <v-col cols="2">
                <v-card-subtitle>2016年</v-card-subtitle>
              </v-col>
              <v-col cols="6">
                <v-card-text>xxxx大会優勝</v-card-text>
              </v-col>
              <v-col cols="4">
                <v-img :src="require('../assets/NoImg.png')" contain width="100%" height="150"></v-img>
              </v-col>
            </v-row>
            <v-divider></v-divider>
            <v-row>
              <v-col cols="2">
                <v-card-subtitle>2016年</v-card-subtitle>
              </v-col>
              <v-col cols="6">
                <v-card-text>xxxx大会優勝</v-card-text>
              </v-col>
              <v-col cols="4">
                <v-img :src="require('../assets/NoImg.png')" contain width="100%" height="150"></v-img>
              </v-col>
            </v-row>
          </v-card>
        </v-col>
      </v-row>
    </div>
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
      overView:{
        teamName: {
          item: "チーム名称",
          value: "ディセット浦和"
        },
        representative: {
          item: "チーム代表",
          value: "川下恭平"
        },
        established: {
          item: "チーム設立",
          value: "2017年6月11日"
        },
        place: {
          item: "活動地域",
          value: "埼玉県志木市、埼玉県さいたま市"
        },
        league: {
          item: "所属リーグ",
          value: "埼玉県フットサルリーグ2部"
        }
        
      }
    }
  }
}
</script>

<style scoped>
  
</style>
