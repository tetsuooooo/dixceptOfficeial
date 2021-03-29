<template>
    <v-row>
        <v-col cols="12" class="padding_none mt-5">
            <v-sheet class="next_match_bg" height="500" tile>
                <v-col cols="12" class="text-h2 text-center white--text">Next Match Infomation</v-col>
                <v-row class="padding_none" align="center" justify="center">
                    <v-col cols="4" sm="5">
                        <v-row class="padding_none" align="center" justify="center">
                            <v-col cols="12" class="text-center padding_none">
                                <v-img :src="require(`../assets/${match.home}`)" width="60%" class="ma-auto padding_none"></v-img>
                            </v-col>
                            <v-col cols="12" class="text-h4 white--text text-center padding_none">{{match.homeName}}</v-col>
                        </v-row>
                    </v-col>
                    <v-col cols="4" sm="2">
                        <v-row align="center" justify="center">
                        <v-col cols="12" class="white--text text-center text-h4">{{match.date}}</v-col>
                        <v-col cols="12" class="text-center text-center">
                                <v-img :src="require('../assets/Next-KickOff.png')" width="100%" class="ma-auto"></v-img>
                        </v-col>
                        <v-col cols="12" class="white--text text-center text-h4">{{match.place}}</v-col>
                        </v-row>
                    </v-col>
                    <v-col cols="4" sm="5">
                        <v-row class="padding_none" align="center" justify="center">
                            <v-col cols="12" class="text-center padding_none">
                                <v-img :src="require(`../assets/${match.away}`)" width="60%" class="ma-auto"></v-img>
                            </v-col>
                            <v-col cols="12" class="text-h4 white--text text-center padding_none">{{match.awayName}}</v-col>
                        </v-row>
                    </v-col>
                </v-row>
            </v-sheet>
        </v-col>
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
          match:{
            home: 'dixsept_header_logo.png',
            away: 'other.png',
            result: 'win.png',
            homeName: 'ディセット浦和',
            awayName: '対戦相手',
            place: '富士見体育館',
        　  date: 'Sat 14:00'
            }
        }
    }
}
</script>

<style scoped>
  .next_match_bg{
      background-color: #026b2f;
  }
</style>
